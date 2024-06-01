using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class employeeDAO : EmployeeContext
    {
        public static void AddEmployee(EMPLOYEE employee)
        {
            try
            {
                db.EMPLOYEE.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void DeleteEmployee(int employeeID)
        {
            try
            {
                EMPLOYEE emp = db.EMPLOYEE.First(x => x.ID == employeeID);
                db.EMPLOYEE.DeleteOnSubmit(emp);
                db.SubmitChanges();                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static List<EmployeeDetailDTO> GetEmployees()
        {
            List<EmployeeDetailDTO> employees = new List<EmployeeDetailDTO>();
            var list = (from e in db.EMPLOYEE
                        join d in db.Department on e.DepartmentID equals d.ID
                        join p in db.POSITION on e.PositionID equals p.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            Name = e.Name,
                            SurName = e.SurName,
                            EmployeeID = e.ID,
                            Password = e.Password,
                            DepartmentName = d.DepartmentName,
                            PositionName = p.PositionName,
                            DepartmentID = p.DepartmentID,
                            PositionID = e.PositionID,
                            isAdmin = e.isAdmin,
                            Salary = e.Salary,
                            ImagePath = e.ImagePath,
                            BirthDay = e.BirtDay,
                            Adress = e.Adress,


                        }).OrderBy(x => x.UserNo).ToList();
            foreach (var item in list)
            {
                EmployeeDetailDTO dto = new EmployeeDetailDTO();
                dto.Name = item.Name;
                dto.UserNo = item.UserNo;
                dto.SurName = item.SurName;
                dto.EmployeeID = item.EmployeeID;
                dto.Password = item.Password;
                dto.DepartmentID = item.DepartmentID;
                dto.DepartmentName = item.DepartmentName;
                dto.PositionID = item.PositionID;
                dto.PositionName = item.PositionName;
                dto.isAdmin = item.isAdmin;
                dto.Salary = item.Salary;
                dto.BrirtDay = item.BirthDay;
                dto.Adress = item.Adress;
                dto.ImagemPath = item.ImagePath;
                employees.Add(dto);
            }
            return employees;
        }

        public static List<EMPLOYEE> GetEmployees(int v, string text)
        {
            try
            {
                List<EMPLOYEE> list = db.EMPLOYEE.Where(x => x.UserNo == v && x.Password == text).ToList();
                return list;
            }           
            catch (Exception)
            {
                throw;
            }
                        
        }      
        public static List<EMPLOYEE> GetUser(int v)
        {
            return db.EMPLOYEE.Where(x=> x.UserNo ==v).ToList();
        }

        public static void UpdateEmployee(int employeeID, int? amount)
        {
            try
            {
                EMPLOYEE employee = db.EMPLOYEE.First(x => x.ID == employeeID);
                employee.Salary = amount.Value;
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void UpdateEmployee(POSITION position)
        {
            List<EMPLOYEE> list=db.EMPLOYEE.Where(x=> x.PositionID == position.ID).ToList();
            foreach (var item in list)
            {
                item.DepartmentID = position.DepartmentID;
            }
            db.SubmitChanges();
        }
        public static void UpdateEmployee(EMPLOYEE employee)
        {
            try
            {
                EMPLOYEE emp = db.EMPLOYEE.First(x => x.ID == employee.ID);
                emp.UserNo = employee.UserNo;
                emp.Name = employee.Name;
                emp.SurName = employee.SurName;
                emp.Password = employee.Password;
                emp.isAdmin= employee.isAdmin;
                emp.BirtDay = employee.BirtDay;
                emp.Adress = employee.Adress;
                emp.DepartmentID = employee.DepartmentID;
                emp.PositionID = employee.PositionID;
                emp.Salary = employee.Salary;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

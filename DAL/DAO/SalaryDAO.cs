using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SalaryDAO : EmployeeContext
    {
        public static void AddSalary(SALARY salary)
        {
            try
            {
                db.SALARY.InsertOnSubmit(salary);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<MONTHS> GetMonths()
        {
            return db.MONTHS.ToList();
        }

        public static List<SalaryDetailDTO> GetSalaries()
        {
            List<SalaryDetailDTO> salaryList = new List<SalaryDetailDTO>();
            var list = (from s in db.SALARY
                        join e in db.EMPLOYEE on s.EmployeeID equals e.ID
                        join m in db.MONTHS on s.MonthID equals m.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            name = e.Name,
                            surname= e.SurName,
                            EmployeeID= s.EmployeeID,
                            amount= s.Amount,   
                            year=s.Year,
                            monthName= m.MonthName,
                            monthID= s.MonthID,
                            salaryID= s.ID,
                            departamentID= e.DepartmentID,
                            positionID= e.PositionID,   

                        }).OrderBy(x=> x.year).ToList();  
            foreach ( var item in list )
            {
                SalaryDetailDTO dto = new SalaryDetailDTO();
                dto.UserNo =item.UserNo;
                dto.Name = item.name;
                dto.SurName = item.surname;
                dto.EmployeeID = item.EmployeeID;
                dto.SalaryAmount= item.amount;
                dto.SalaryYear= item.year;
                dto.MonthName= item.monthName;
                dto.MonthID= item.monthID;
                dto.SalaryID = item.salaryID;
                dto.DepartmentID= item.departamentID;
                dto.PositionID= item.positionID;
                dto.OldSalary = item.amount;
                salaryList.Add(dto);
            }
            return salaryList;
        }
    }
}

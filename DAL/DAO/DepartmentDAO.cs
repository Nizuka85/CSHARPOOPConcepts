using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(Department department)
        {
            try
            {
                db.Department.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public static List<Department> GetDepartments()
        {
            return db.Department.ToList();
        }

        public static void UpdateDepartment(Department department)
        {
            try
            {
                Department dtp = db.Department.First(x => x.ID == department.ID);
                dtp.DepartmentName=department.DepartmentName;
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

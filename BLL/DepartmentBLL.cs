using System;
using DAL;
using DAL.DAO;
namespace BLL
{
    public class DepartmentBLL
    {
        public static void AddDepartment(Department department)
        {
            DepartmentDAO.AddDepartment(department);
        }
    }
}

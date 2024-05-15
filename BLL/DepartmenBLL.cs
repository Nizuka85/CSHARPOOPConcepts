using DAL;
using DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmenBLL
    {
        public static void AddDepartment(Department department)
        {
            EmployeeDAO.AddDepartment(department);
        }
        
    }
}

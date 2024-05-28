using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class EmployeeBLL
    {
        

        public static EmployeeDTO GetAll()
        {
            EmployeeDTO dto = new EmployeeDTO();
            dto.Departments = DepartmentDAO.GetDepartments();
            dto.positions= PositionDAO.GetPositions();
            dto.Employees = employeeDAO.GetEmployees();
            return dto; 
        }
        public static void AddEmployee(EMPLOYEE employee)
        {
            employeeDAO.AddEmployee(employee);

        }

        public static bool isUnique(int v)
        {
            List<EMPLOYEE> list = employeeDAO.GetUser(v);
            if(list.Count > 0)            
                return false;
            else
                return true;
            
        }

        public static List<EMPLOYEE> GetEmployees(int v, string text)
        {
            return employeeDAO.GetEmployees(v, text);
        }
    }
}

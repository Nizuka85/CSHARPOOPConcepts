using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double EmployeeSalary { get; set; }
        public void SetValue(int ID)
        {
            EmployeeID = ID;
        }
        public void SetValue(int ID, string EmployeeName)
        {
            EmployeeID = ID;
            Name = EmployeeName;
        }
        public void SetValue(int ID, string EmployeeName, double Salary)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;
        }
    }
}

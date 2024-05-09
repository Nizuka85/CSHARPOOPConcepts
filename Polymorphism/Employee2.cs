using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Employee2
    {
        protected int EmployeeID { get; set; }
        public string Name { get; set; }
        public double EmployeeSalary { get; set; }
        public string EmployeePosition { get; set; }

        public virtual string SetValue(int ID, string EmployeeName, double Salary)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;

            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            return text;
            
        }
    }
}

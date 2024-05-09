using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Teacher:Employee
    {
        public string EmployeePosition {  get; set; }
        public void SetValue(int ID, string EmployeeName, double Salary, string position)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;
            EmployeePosition = position;
        }

        public string GetValues()
        {
            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return text;
        }     
    }
}

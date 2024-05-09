using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Teacher2:Employee2
    {
        override public string SetValue(int ID, string EmployeeName, double Salary)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;
            EmployeePosition = "teacher";

            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return text;

        }


    }
}

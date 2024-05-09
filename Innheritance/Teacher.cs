using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innheritance
{
    internal class Teacher:Employee
    {
        public string Branch {  get; set; }
        public void FindSalary()
        {
            Salary = 2000;
        }
        public void SetValues2()
        {
            Position = "Teacher";
            Branch = "Math";
        }
    }
}

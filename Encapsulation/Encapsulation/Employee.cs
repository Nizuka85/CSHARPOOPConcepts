using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Employee
    {
        protected int EmployeeID { get; set; }

        public int EmployeeAge { get; set; }    

        public string EmployeeName { get; set; }

        public string EmployeePosition { get; set; }

    }
}

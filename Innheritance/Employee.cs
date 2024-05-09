using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innheritance
{
    internal class Employee:human
    {
        protected string Position { get; set; }
        protected double Salary { get; set; }
        public void Setvalues()
        {
            Name = "Charles";
            ID = 1;
            Gerder = 'M';
            Age = 30;
        }
    }
}

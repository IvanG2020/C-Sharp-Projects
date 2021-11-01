using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person
    {
        public Employee(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }

        public override void SayName()
        {
            throw new NotImplementedException();
        }
    }
}

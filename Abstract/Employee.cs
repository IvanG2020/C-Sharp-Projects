using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {
        public Employee(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }

        public void Quit(string reason)
        {
            Console.WriteLine("I Quit! Don't forget to mail my check.");
            Console.WriteLine(reason);
            Console.WriteLine("\t- {0}", FirstName);
        }

        public override void SayName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
}
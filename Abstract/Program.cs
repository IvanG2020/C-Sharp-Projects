using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sample", "Student");
            employee.SayName();
            Console.ReadLine();

            IQuittable Jeremy = new Employee("Ivan", "Galas");
            Jeremy.Quit("I found a new job. Thanks Tech Academy!");
            Console.ReadLine();
        }
    }
}
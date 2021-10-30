using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Type a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number times 10 is: ");

            Maths multi = new Maths();
            multi.Multi(number);
            Console.ReadLine();

            Console.WriteLine("Your number plus 100 is : ");

            Maths add = new Maths();
            add.Adding(number);
            Console.ReadLine();

            Console.WriteLine("Your number divided by 2 is : ");

            Maths divi = new Maths();
            divi.Divide(number);
            Console.ReadLine();

        }
    }
}
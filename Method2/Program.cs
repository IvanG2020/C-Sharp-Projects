using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewClass newClass = new NewClass();

            Console.WriteLine("Enter a number to be divided by two");
            int usersInput = Convert.ToInt32(Console.ReadLine());

            newClass.numberOne(usersInput);

            Console.WriteLine(newClass);
            Console.ReadLine();



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to use in various equations!");
            int userIn = Convert.ToInt32(Console.ReadLine());


            Methods obj1 = new Methods();
            obj1.Multiply(userIn);

            Methods obj2 = new Methods();
            obj2.Divide(userIn);

            Methods obj3 = new Methods();
            obj3.Add(userIn);
            Console.ReadLine();
        }

    }
}
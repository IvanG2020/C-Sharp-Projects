using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method4
{
    class Program
    {
        public static object StaticClass { get; private set; }

        static void Main(string[] args)
        {
            Class1 mathObject = new Class1(); // Instantiating an object

            Console.WriteLine("Enter a number: ");
            string user = Console.ReadLine();
            int x = Convert.ToInt32(user);

            mathObject.MyMethod(x); // Calling the method
            Console.ReadLine();


            Class1 mathObject2 = new Class1();
            // local variable defintion
            int a, b;

            // Calling a method to get the values
            mathObject2.GetValue(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.ReadLine();



            // Calling static method
            StaticClass.ToString();



        }

    }
}
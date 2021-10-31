using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps FirstOp = new MathOps();
            Console.WriteLine("Pick a number:");
            FirstOp.num1 = Convert.ToInt32(Console.ReadLine());

            try
            {
               
                Console.WriteLine("Pick a second number. Press return if you do not want a second number:");
                FirstOp.num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                FirstOp.num2 = 15;

            }
            int sum = FirstOp.MathMethod(FirstOp.num1,FirstOp.num2);
            Console.WriteLine(sum);

            Console.WriteLine("Thank you for stopping by!");
            Console.ReadLine();

            

        }
    }
}
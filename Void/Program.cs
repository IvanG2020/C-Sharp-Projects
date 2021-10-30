using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{ 
    public class Program
{
    public static void Main(string[] args)
    {
        //instantiate class
        Math math = new Math();
        math.num1 = 15;
        math.num2 = 10;

        //takes user input as integer variables and adds them together
        Console.WriteLine("Please enter a number.");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered " + num1 + ". Please enter a second number.");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number is " + num2 + ". Adding numbers together...");
        int result = num1 + num2;
        Console.WriteLine("The result is " + result);
            Console.ReadLine();

        //call class method specifying parameter names
        math.add1(num1, num2);




        //Console.WriteLine("Doing more math...");
        ////passing in integers as plain integers
        //Math.add1(15, 25);
        ////passing in integer variables by name
        //Math.add1(num1 = 20, num2 = 50);
    }
}
}
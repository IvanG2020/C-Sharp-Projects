using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total + othertotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Five minus Ten = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueorfalse = 12 > 5;
            //Console.Write(trueorfalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currenttemp = 72;

            //bool iswarm = currenttemp > roomTemp;
            //Console.WriteLine(iswarm);
            //Console.ReadLine();

            // The start of the program. just printing messages to the user
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Please press Enter to start.");
            Console.ReadLine();

            //Person 1 info
            Console.WriteLine("Person 1");

            //Person 1 hourly rate
            Console.WriteLine("What is your hourly rate. Please use Digits only");
            string payRate = Console.ReadLine();
            decimal payRate1 = Convert.ToInt32(payRate);
            Console.WriteLine(payRate1);
            Console.ReadLine();

            //Person 1 hours worked this week
            Console.WriteLine("How many hours did you work this week Please use Digits only");
            string hours = Console.ReadLine();
            decimal hours1 = Convert.ToInt32(hours);
            Console.WriteLine(hours1);
            Console.ReadLine();

            //Person 2 info
            Console.WriteLine("Person 2");

            //Person 2 hourly rate
            Console.WriteLine("What is your hourly rate. Please use Digits only");
            string payRate2 = Console.ReadLine();
            decimal payRate22 = Convert.ToInt32(payRate2);
            Console.WriteLine(payRate22);
            Console.ReadLine();

            //Person 2 how many hours did you work this week
            Console.WriteLine("How many hours did you work this week Please use Digits only");
            string hours2 = Console.ReadLine();
            decimal hours22 = Convert.ToInt32(hours2);
            Console.WriteLine(hours22);
            Console.ReadLine();

            //Annual salary for Person 1
            Console.WriteLine("Annual salary for Person 1");
            decimal salaryOne = payRate1 * hours1 * 12;
            Console.WriteLine("Annual salary of person 1 is " + salaryOne);
            Console.ReadLine();

            //Annual salary for person 2 
            Console.WriteLine("Annual salary for Person 2");
            decimal salaryTwo = payRate22 * hours22 * 12;
            Console.WriteLine("Annual salary of person 2 is " + salaryTwo);
            Console.ReadLine();

            //Does person 1 make more money than person 2?
            Console.WriteLine("Does Person 1 make more money than person 2?");
            bool greaterThan = salaryOne > salaryTwo;
            Console.WriteLine("Person 1 makes more than Person 2: " + greaterThan);
            Console.ReadLine();


        }
    }
}

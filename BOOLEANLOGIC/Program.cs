using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOLEANLOGIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 && packageWidth > 25);
            //Console.WriteLine(tooBig);

            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 || packageWidth > 25);
            //Console.WriteLine(tooBig);
            //Output is false

            //string firstName = "Jesse";
            //string lastName = "Johnson";
            //string socialSecurityNumber = "111-11-1111";

            //bool isAuthorized = (firstName == "Jesse" && lastName == "Johnson" && socialSecurityNumber = "111-11-1111");
            //Console.WriteLine(isAuthorized);

            //bool result = (true && (true || false));
            //Console.WriteLine(result);

            //int num1 = 7;
            //int num2 = 12;
            //int num3 = 23;
            //int num4 = 14;
            //int num5 = 8;
            //int num6 = 5;

            ////bool result = (num1 > num2 && (num3 == num4 || num5 > num6));
            ////Console.WriteLine(result);

            //// &-AND OP 
            //Console.WriteLine(true && false); // False
            //Console.WriteLine(true && true); // True
            //Console.WriteLine(false && false);// False

            ////OR OP
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            // Equal to OP
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //// Not Equal to OP
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //XOP
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            // What is your age
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageOne = Convert.ToInt32(age);
            Console.ReadLine();

            //Has the client had a Dui Before
            //requesting input of help needed? boolian would be done to perform the data type statement returning true or false
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool noDui = Convert.ToBoolean(Console.ReadLine());


            //if statement
            if (noDui == true)
            {
                Console.WriteLine("Client Has DUI's! "); //returns our boolean statement as true help is needed
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Client Has a clean RECORD!! "); //returns boolean statement as false does not need help
                Console.ReadLine();
            }

            // How many speeding tickets has a client obtained
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(tickets);
            Console.ReadLine();

            if (ageOne >= 15 && noDui && speedingTickets >= 3)
            {
                Console.WriteLine("You are qualified");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You are not qualified");
                Console.ReadLine();
            }
        }
    }
}

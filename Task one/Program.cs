using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_one
{
    class Program
    {
        static void Main(string[] args)
        {
            ///asking the console to write with the WriteLine the two strings.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //console question for your name.
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName);
           

            //requesting input of current course.
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("You currently are on course " + course);

            //requesting input of page number currently on.
            Console.WriteLine("What Page Number are you on?.");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);//perfroms a caste conversion string to int
            Console.WriteLine("you are currently on page number " + pageNumber);

            //requesting input of help needed? boolian would be done to perform the data type statement
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool isHelpNeeded = Convert.ToBoolean(Console.ReadLine());
            bool helpIsNeeded = true;
            bool helpIsNotNeeded = false;

            //if 
            if (helpIsNeeded)
            {
                Console.WriteLine("Student needs help! " + helpIsNeeded); //returns our boolean statement as true help is needed
                Console.ReadLine();

            }
            if (helpIsNotNeeded)
            {
                Console.WriteLine("Student does not need help! " + helpIsNotNeeded); //returns boolean statement as false does not need help
                Console.ReadLine();

            }


            //requesting input 
            Console.WriteLine("Were there any posistive experiences you'd like to share? Please give specific.");
            string exp = Console.ReadLine();
            Console.WriteLine("Thank you for your submission of positive experiences: " + exp);

            //requesting input of feedback to your instructor
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string fbk = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback! " + fbk);
            Console.ReadLine();
        }
    }
}
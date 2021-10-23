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
            //Starting text
            string rows = "The Tech Academy\r\nStudent Daily Report\r\nPress Enter to Begin";
            Console.WriteLine(rows);
            Console.ReadLine();
            // Asking for name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.ReadLine();
            // what course are you attending
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.ReadLine();
            // what page of that course are you on
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            //a bool is used
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needHelp = Boolean.Parse("true");
            bool noHelp = Boolean.Parse("false");
            Console.ReadLine();
            // string
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.ReadLine();
            // is there any feedback from user
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.ReadLine();
            // how many hours did a student study
            Console.WriteLine("How many hours did you study today?");
            int studyTime = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            // final message to student
            string endMessage = "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!";
            Console.WriteLine(endMessage);
            Console.ReadLine();
        }
    }
}

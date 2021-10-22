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
            // Welcoming message
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
    
            //First Question asking your name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            

            // What course have you reached
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("The course your in is: " + course);
            

            // what page of the course are you on?
            Console.WriteLine("What Page Number?");
            string page = Console.ReadLine();
            Console.WriteLine("The page you are on is: " + page);
            

            // Are there any questions for intructors
            Console.WriteLine("Do you need help with anything? please answer true or false");
            string help = Console.ReadLine();
            Console.WriteLine("you need help with: " + help);
            

            // Detailed question
            Console.WriteLine("Were there any posistive experiences you'd like to share? Please give specific.");
            string question = Console.ReadLine();
            Console.WriteLine("you need help with: " + question);
            


            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("your Feedback is: " + feedback);
            

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("you spent : " + hours + "hours on your work today");
            


            // Printing Final message
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great Day!");
            Console.ReadLine();
        }
    }
}
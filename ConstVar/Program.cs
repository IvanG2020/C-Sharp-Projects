using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var newPlayer = Console.ReadLine();
            const string myName = "Ivan";
            Console.WriteLine("Hello, {0}, my name is {1}, welcome to my program!", newPlayer, myName);
            Console.ReadLine();



        }
    }
}
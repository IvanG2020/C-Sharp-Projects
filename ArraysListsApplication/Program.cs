using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("Cats and Dogs");
            animals.Add("Frogs and snakes");
            animals.Add("Sea Pickles and Sea Biscuits");

            Console.WriteLine("Select an index from 0 to 2! The outcome will be the animals you will live with forever PICK WISELY!!");
            int selectionThree = Convert.ToInt32(Console.ReadLine());

            if (selectionThree == 0)
            {
                Console.WriteLine(animals[0]);
                Console.ReadLine();
            }
            else if (selectionThree == 1)
            {
                Console.WriteLine(animals[1]);
                Console.ReadLine();
            }
            else if (selectionThree == 2)
            {
                Console.WriteLine(animals[2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This index does not exsist.");
                Console.ReadLine();
            }
        }
    }
}

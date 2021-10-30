using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEAPPsTRINGSINTEGERS
{
    class Program
    {
        static void Main()
        {

            string[] stringArray1 = new string[] { "Rain, Mortal Kombat", "Fox, SpaceFox", "CT, Counter-Strike", "Bill Gates, Apple" };
            Console.WriteLine("Please select an index of the array 0-3: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection > 3 || selection < 0)
            {
                Console.WriteLine("Please try again. Select an index between 0 and 3");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(stringArray1[selection]);
                Console.ReadLine();
            }



            int[] numArray = new int[] { 26, 10, 7, 27, 6 };
            Console.WriteLine("Please select an index of the array: ");
            int selection1 = Convert.ToInt32(Console.ReadLine());

            if (selection1 > 4 || selection < 0)
            {
                Console.WriteLine("Please try again. Select an index between 0 and 4");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray[selection1]);
                Console.ReadLine();
            }

            List<string> stringList = new List<string>();
            stringList.Add("Pikachu");
            stringList.Add("Eevee");
            stringList.Add("Jigglypuff");
            stringList.Add("Squirtle");
            stringList.Add("Bulbasaur");
            Console.WriteLine("Hello, please select an index of the pokemon array: ");
            int selection2 = Convert.ToInt32(Console.ReadLine());

            if (selection2 > 4 || selection < 0)
            {
                Console.WriteLine("Please try again. Select an index between 0 and 4");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(stringList[selection2]);
                Console.ReadLine();
            }
        }

    }
}
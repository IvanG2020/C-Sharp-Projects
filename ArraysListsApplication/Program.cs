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
            //Declaring single dimensional array
            string[] Books = new string[5];
            Books[0] = "C#";
            Books[1] = "Java";
            Books[2] = "VB.NET";
            Books[3] = "C++";
            Books[4] = "C";

            Console.WriteLine("All the element of Books array is:\n\n");

            int i = 0;
            //Formatting Output
            Console.Write("\t1\t2\t3\t4\t5\n\n\t");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", Books[i]);
            }
            Console.ReadLine();

        }

        static void OneDimensionalArray()
        {
            int[] grades = new int[8];

            grades[0] = 57;
            grades[1] = 60;
            grades[2] = 68;
            grades[3] = 72;
            grades[4] = 65;
            grades[5] = 75;
            grades[6] = 81;
            grades[7] = 84;

            WriteOneDimensionalArrayToScreen(grades);


        }

        static void WriteOneDimensionalArrayToScreen(int[] array)
        {
            for (int count = 0; count <= array.Length - 1; count++)
            {
                Console.WriteLine($"{array[count]}");

            }

     

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OneDimensionalArray
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] randomStrings = { "I don't know ", "Let me think about that ", "Sure, that sounds fun " };

                Console.WriteLine("Enter some text!");
                string usersInput = Console.ReadLine();

                foreach (string name in randomStrings)
                {
                    Console.WriteLine(name + usersInput); 
                }
                Console.ReadLine();

                while (true)
                {
                   Console.WriteLine("Hello?");
                    break;
                }
                Console.ReadLine();

                Console.WriteLine("Enter a random number?");
                int randomNumber = Convert.ToInt32(Console.ReadLine());


                while (randomNumber < 50)
                {
                    Console.WriteLine(randomNumber);
                    randomNumber++;

                }
                Console.ReadLine();

                Console.WriteLine("Enter a random number?");
                int randomNumbers = Convert.ToInt32(Console.ReadLine());


                while (randomNumbers <= 30)
                {
                  Console.WriteLine(randomNumbers);
                    randomNumbers++;

                }
                Console.ReadLine();

                List<String> testing = new List<String>();
                testing.Add("I like candy");
                testing.Add("The sky is blue");
                testing.Add("Tomorrow it should be sunny");


                Console.WriteLine("Enter text you want to search");
                string search = Console.ReadLine();
                bool right = true;

               foreach(string item in testing)
                {
                    if (search == item)
                    {
                        Console.WriteLine(testing.IndexOf(item));
                        right = true;
                        break;
                    }
                   else
                   {
                       Console.WriteLine("Please enter text again");
                    }
                }
                Console.ReadLine();

                List<String> nString = new List<string>();

                nString.Add("I like green");
                nString.Add("I like green");
                nString.Add("I like blue");

                Console.WriteLine("Type the text you want to search for");
                string myColor = Console.ReadLine();
                bool correct = true;

                foreach(string colors in nString)
                {
                    if (myColor == colors)
                    {
                        Console.WriteLine(nString.IndexOf(myColor));
                        correct = true;



                   }
                    else
                    {
                        Console.WriteLine("You entered text that isn't in the list");
                       Console.ReadLine();
                    }
                } 

                List<String> newString = new List<string>();

                newString.Add("The red rock");
                newString.Add("The red rock");
                newString.Add("The blue rock");

                foreach (string colors in newString)
                {
                    Console.WriteLine(colors);
                    Console.ReadLine();
                }
            }

        }
    }
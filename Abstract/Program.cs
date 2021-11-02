using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
       static void Main(string[] args)
            {
                Employee<string> sampleEmployee = new Employee<string>();
                sampleEmployee.FirstName = "Sample";
                sampleEmployee.LastName = "Student";
                sampleEmployee.Id = 100;
                sampleEmployee.things = new List<string>() { "Crescent Wrench", "Torx Driver", "Staple Gun", "Wire Crimps", "Soldering Iron" };
                sampleEmployee.SayName();
                Console.WriteLine("Employee ID: " + Convert.ToString(sampleEmployee.Id));
                Console.WriteLine("First Employee's List of Tools:");
                foreach (string tool in sampleEmployee.things)
                {
                    Console.WriteLine(tool);
                }

                Employee<string> employeeTwo = new Employee<string>();
                employeeTwo.Id = 100;
                bool sameIDs = employeeTwo == sampleEmployee;
                Console.WriteLine("sampleEmployee and employeeTwo have identical IDs: " + Convert.ToString(sameIDs));
                Employee<int> employeeThree = new Employee<int>();
                employeeThree.things = new List<int>() { 2, 3, 5, 7, 11 };
                Console.WriteLine("Employee Three's List of Favorite Numbers:");
                foreach (int num in employeeThree.things)
                {
                    Console.WriteLine(Convert.ToString(num));
                }

                sampleEmployee.Quit();

                IQuittable quitTime = new Employee<double>();

                Console.WriteLine("It's time to go...");
                quitTime.Quit();

            }
        }
    }
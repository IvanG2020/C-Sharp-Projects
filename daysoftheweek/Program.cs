using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysoftheweek
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the day of the week.");

                var enumAsName = Console.ReadLine();
                var enumFromString = Enum.Parse(typeof(weekDays), enumAsName);
                


                Console.WriteLine(enumFromString);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
               
            }
        
        }
        public enum weekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
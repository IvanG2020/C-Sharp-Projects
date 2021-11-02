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
            //build dictionary for string parsing to enum 
            Dictionary<string, DaysoftheWeek> DayParser = new Dictionary<string, DaysoftheWeek>();
            DayParser.Add("MONDAY", DaysoftheWeek.Monday);
            DayParser.Add("TUESDAY", DaysoftheWeek.Tuesday);
            DayParser.Add("WEDNESDAY", DaysoftheWeek.Wednesday);
            DayParser.Add("THURSDAY", DaysoftheWeek.Thursday);
            DayParser.Add("FRIDAY", DaysoftheWeek.Friday);
            DayParser.Add("SATURDAY", DaysoftheWeek.Saturday);
            DayParser.Add("SUNDAY", DaysoftheWeek.Sunday);

            Console.WriteLine("Hello. Please enter the current day of the week:");
            string inputString = "";  //Initialize as blank to enter while loop
            DaysoftheWeek inputDay = DaysoftheWeek.Friday;  //Initialize outside loop, will change with input
            while (!DayParser.ContainsKey(inputString))
            {
                inputString = Console.ReadLine().ToUpper().Trim();  //uppercase to avoid capitalization errors
                try
                {
                    inputDay = DayParser[inputString];
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("That does not appear to be a valid day of the week. Please try again.");
                }

            }
            Console.WriteLine("You entered {0}. Thank you.", inputDay);
            Console.ReadLine();
        }

        public enum DaysoftheWeek
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
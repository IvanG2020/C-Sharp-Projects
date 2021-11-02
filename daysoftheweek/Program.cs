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

            Console.WriteLine("Enter the current day of the week: ");
            string dayOfTheWeek = Console.ReadLine();

            try
            {
                if (dayOfTheWeek == "Monday" || dayOfTheWeek == "monday")
                {
                    Class1.DaysOfTheWeek.Monday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek == "Tuesday" || dayOfTheWeek == "tuesday")
                {
                    Class1.DaysOfTheWeek.Tuesday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek == "Wednesday" || dayOfTheWeek == "wednesday")
                {
                    Class1.DaysOfTheWeek.Wednesday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek == "Thursday" || dayOfTheWeek == "thursday")
                {
                    Class1.DaysOfTheWeek.Thursday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek == "Friday" || dayOfTheWeek == "friday")
                {
                    Class1.DaysOfTheWeek.Friday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "saturday")
                {
                    Class1.DaysOfTheWeek.Saturday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek == "Sunday" || dayOfTheWeek == "sunday")
                {
                    Class1.DaysOfTheWeek.Sunday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);
                    Console.ReadLine();
                }
                else if (dayOfTheWeek != "" || dayOfTheWeek == "")
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();
                }
            }
            catch
            {

                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysoftheweek
{
   class Program
    {
       
        enum DaysOfTheWeek { Monday , Tuesday, Wednsday, Thursday, Friday, Saturday, Sunday  };

        public static void Main()
        {
            Console.WriteLine("please enter the current day of the week.");
            
            
            string DaysOfTheWeek = Console.ReadLine();
          
            {
               try
                {
                    
                  DaysOfTheWeek Friday = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek),DaysOfTheWeek);
                    Console.WriteLine(Friday);
                    Console.WriteLine("You entered:" + Friday);
                    Console.ReadLine();

                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();
                }
                
            }
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        public static void Main()
        {
            int opInt = 15;
            Math.mathTime(opInt);

            decimal opDec = 22.57m;
            Math.mathTime(opDec);

            string opString = "32";
            Math.mathTime(opString);

            Console.ReadLine();
        }
    }
}
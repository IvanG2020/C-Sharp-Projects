using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    public class Math
    {
        public static void mathTime(int opInt)
        {
            int addNum = 10;
            int resAdd = addNum + opInt;
            Console.WriteLine(resAdd);
        }

        public static void mathTime(decimal opDec)
        {
            decimal decMult = opDec * 7;
            Console.WriteLine(Convert.ToInt32(decMult));
        }


        public static void mathTime(string opStr)
        {
            decimal strAdd = Convert.ToInt32(opStr) + 25;
            Console.WriteLine(strAdd);
        }
    }
}
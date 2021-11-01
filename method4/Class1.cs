using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method4
{
    public class Class1
    {
        public void MyMethod(int x)
        {
            int result = x / 2;

            Console.WriteLine(x + " divided by 2 = " + result);
            return;
        }
        public void MyMethod(double x)
        {
            double result = x / 2;

            Console.WriteLine(x + " divided by 2 = " + result);
            return;
        }

        public void GetValue(out int x, out int y)
        {
            Console.WriteLine("Please enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }



    }
}

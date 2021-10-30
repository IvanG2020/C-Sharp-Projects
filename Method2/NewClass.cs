using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class NewClass
    {
        public void numberOne(int num1)
        {
            num1 = num1 / 2;

            Console.WriteLine(num1);
            Console.ReadLine();
        }
        public void numberOne(int num1, out int num2)
        {
            num2 = num1 / 4;
        }
    }
}
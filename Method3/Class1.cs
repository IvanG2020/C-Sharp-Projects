using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    public class MathOps
    {
       public int num1 { get; set; }
       public int num2 { get; set; }
        public int MathMethod(int num1, int num2 = 15)
        {
            //int result = 0;
            //if (answer == "")
            //{
            //    result = num1 + 10;

            //}
            //else
            //{
            //    int num2 = Convert.ToInt32(answer);
            

            int result = num1 + num2;
               return result;

        }

    }
}
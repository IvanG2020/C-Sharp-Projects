using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    public class MathOps
    {
        public int MathMethod(int num1, string answer)
        {
            int result = 0;
            if (answer == "")
            {
                result = num1 + 10;

            }
            else
            {
                int num2 = Convert.ToInt32(answer);
                result = num1 + num2 + 10;
            }
            return result;

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{ 
    public class Math
{
    public int num1 { get; set; }
    public int num2 { get; set; }

    public void add1(int num1, int num2)
    {
        int sum = num1 + 10;
        Console.WriteLine(sum);
        Console.WriteLine(num2);
        return;
    }
}

}
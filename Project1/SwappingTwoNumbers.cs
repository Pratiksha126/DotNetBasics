using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class SwappingTwoNumbers
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine( "before swap: a="+a+"b="+b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swap: a="+a+"b="+b);
        }
    }
}

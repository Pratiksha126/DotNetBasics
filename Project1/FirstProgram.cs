using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter anumber:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Addition is:"+c);




        }
    }
}

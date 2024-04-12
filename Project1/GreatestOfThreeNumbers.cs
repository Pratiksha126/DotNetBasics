using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class GreatestOfThreeNumbers
    {
        static void Main(string args[])
        {
            Console.WriteLine("Enter any number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1+"is greater");
            }
            if (num2 > num3)
            {
                Console.WriteLine(num2+"is greater");
            }
            if(num3>num1)
            {
                Console.WriteLine(num3+"is greater");
            }



        }
    }
}

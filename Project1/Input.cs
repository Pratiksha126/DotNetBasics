using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project1
{
    public class Input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your name is"+" "+name+" "+"your age is"+" "+age+" "+"and your salary is "+" "+salary);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Enter height of the triangle:");
            double h1 =Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Enter base of the triangle:");
            double b1 = Convert.ToDouble(Console.ReadLine());

            double area =0.5* h1 * b1;
            Console.WriteLine("Area of traingle is:"+" "+area);

        }
    }
}

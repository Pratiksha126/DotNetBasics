using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project1
{
    public class AreaOfCircle2
    {
        static void Main(string[] args)
        {
            float pi = 3.142f;

            Console.WriteLine("Enter the radius to find the Area of circle:");
            int r = Convert.ToInt32(Console.ReadLine());

            float AreaOfCicle = pi * r * r;

            Console.WriteLine("Area of circle is:"+" "+ AreaOfCicle);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class AverageOfTheMarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the subject1 marks:");
            double s1 =Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Enter the subject2 marks:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the sub3 marks:");
            double s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the sub4 marks:");
            double s4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the sub5 marks:");
            double s5 = Convert.ToDouble(Console.ReadLine());

            double total =s1 + s2 + s3 + s4 + s5;
            double percentage = (total / (5 * 100)) * 100;


            Console.WriteLine("Percentage:"+percentage);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class IfElse1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5==0)
                {
                    Console.WriteLine("Welcome to Pune");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Welcome");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Pune");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

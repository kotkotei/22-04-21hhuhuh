﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//4.87
            Console.WriteLine("Ввели x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x <= 0)
            {
                y = 0;
            }
            else if (x > 0 && x <= 1)
            {
                y = x;
            }
            else
            {
                y = x + x;
            }
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}

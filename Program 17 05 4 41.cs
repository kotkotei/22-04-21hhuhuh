using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)

        {//4.41
            Console.WriteLine("Ввели x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x >= 0.2 && x <= 0.9)
            {
                y = Math.Sin(x);
            }
            else
            {
                y = 1;

            }
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
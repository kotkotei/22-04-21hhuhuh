using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//4.89
            Console.WriteLine("Ввели k");
            double k = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            if (Math.Sin(x) >= 0)
            {
                x = Math.Pow(x, 2);
            }
            else


            {
                x = Math.Abs(x);
            }
            double y = 0;
            if (k < x)
            {
                y = Math.Abs(k);
            }
            else
            {
                y = x * k;
            }
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}

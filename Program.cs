using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {//5,28 B
            Console.WriteLine(" введите число b ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 20; i >= 1; i++)
            {
                Console.WriteLine(i + "от" + i + n + "до");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        { /*Составить программу "КАЛЬКУЛЯТОР", которая после ввода
двух чисел и одного из чисел 1 2 3 4 ( которые соответствуют +, -, *, /
)произведёт вычисления, а результат выдаст на экран.
            */

            Console.WriteLine("Введите 1-ое число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 2 3 4(которые соотвествуют +.-,*,/,");
            double z = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            switch (z)
            {
                case 1: c = x + y; break;
                case 2: c = x + y; break;
                case 3: c = x + y; break;
                default: Console.WriteLine("Ошибка выбора оператора"); break;
            }
            Console.WriteLine(c);
            Console.ReadKey();
            }
    }
}

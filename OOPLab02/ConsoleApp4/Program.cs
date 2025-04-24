using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №2 Завдання 4");
            Console.WriteLine("Виконав Місік І.В. ВТ-21-1");
            int N, K;
            double res = 0;
            bool p;
            do
            {
                Console.WriteLine("Введіть N = ");
                p = int.TryParse(Console.ReadLine(), out N);
                if (!p | N <= 0)
                {
                    Console.WriteLine("Неправильно введено N");
                    if (N <= 0)
                    {
                        p = false;
                    }
                }
            } while (!p);
            do
            {
                Console.WriteLine("Введіть K = ");
                p = int.TryParse(Console.ReadLine(), out K);
                if (!p | K <= 0)
                {
                    Console.WriteLine("Неправильно введено K");
                    if (K <= 0)
                    {
                        p = false;
                    }
                }
            } while (!p);
            for (int i = 0; i < N;)
            {
                i++;
                res += Math.Pow(i, K);
            }
            Console.WriteLine("Сума = {0:F0}", res);
            Console.ReadKey();
        }
    }
}

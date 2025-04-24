using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Console.WriteLine("Лабораторна робота №2 Завдання 1");
            Console.WriteLine("Виконав Місік І.В. ВТ-21-1");
            double x, y, z;
            double a, b, c, d, r, s;
            bool p;
            do
            {
                Console.WriteLine("Введіть x = ");
                p = double.TryParse(Console.ReadLine(), out x);
                if (!p)
                {
                    Console.WriteLine("Неправильно введено х");
                }
            } while (!p);
            do
            {
                Console.WriteLine("Введіть y = ");
                p = double.TryParse(Console.ReadLine(), out y);
                if (!p)
                {
                    Console.WriteLine("Неправильно введено y");
                }
            } while (!p);
            do
            {
                Console.WriteLine("Введіть z = ");
                p = double.TryParse(Console.ReadLine(), out z);
                if (!p)
                {
                    Console.WriteLine("Неправильно введено z");
                }
            } while (!p);
            a = Math.Pow(y, x + 1);
            b = Math.Pow(Math.Abs(y - 2) + 3, 1.0 / 3);
            c = x + y / 2;
            d = 2 * Math.Abs(x + y);
            r = Math.Pow(x + 1, -1.0 / Math.Sin(z));
            s = (a / b) + (c / d) * r;
            Console.WriteLine("Результат: {0:F3}", s);
            Console.ReadKey();
        }
    }
}

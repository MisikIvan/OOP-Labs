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
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №2 Завдання 2");
            Console.WriteLine("Виконав Місік І.В. ВТ-21-1");
            double D, x1, x2, a, b, c;
            bool p;
            do
            {
                Console.WriteLine("Введіть a = ");
                p = double.TryParse(Console.ReadLine(), out a);
                if (!p | a == 0)
                {
                    Console.WriteLine("Неправильно введено a");
                    if (a == 0)
                    {
                        p = false;
                    }
                }
            } while (!p);
            do
            {
                Console.WriteLine("Введіть b = ");
                p = double.TryParse(Console.ReadLine(), out b);
                if (!p)
                {
                    Console.WriteLine("Неправильно введено b");
                }
            } while (!p);
            do
            {
                Console.WriteLine("Введіть c = ");
                p = double.TryParse(Console.ReadLine(), out c);
                if (!p)
                {
                    Console.WriteLine("Неправильно введено c");
                }
            } while (!p);
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискримінант = {0}", D);
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Корінь 1 = {0:F3}", x1);
                Console.WriteLine("Корінь 2 = {0:F3}", x2);
            }
            if (D == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine("Корінь = {0:F3}", x1);
            }
            if (D < 0)
            {
                Console.WriteLine("Коренів немає");
            }
            Console.ReadKey();
        }
    }
}

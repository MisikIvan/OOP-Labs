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
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №2 Завдання 5");
            Console.WriteLine("Виконав Місік І.В. ВТ-21-1");
            int chyslo, par = 0, nepar = 0, dod = 0, vid = 0;
            bool p;
            Console.WriteLine("Введіть цілі числа через Enter, 0 - завершує роботу");
            do
            {
                do
                {
                    p = int.TryParse(Console.ReadLine(), out chyslo);
                    if (!p)
                    {
                        Console.WriteLine("Введіть ціле число");
                    }
                } while (!p);
                if (chyslo % 2 == 0 && chyslo != 0)
                {
                    par++;
                }
                if (chyslo % 2 != 0 && chyslo != 0)
                {
                    nepar++;
                }
                if (chyslo > 0)
                {
                    dod++;
                }
                if (chyslo < 0)
                {
                    vid++;
                }
                if (chyslo == 0)
                {
                    break;
                }
            } while (chyslo != 0);
            Console.WriteLine("Парних чисел:{0}\nНепарних чисел:{1}\nДодатних чисел:{2}\nВід'ємних чисел:{3}", par, nepar, dod, vid);
        }
    }
}

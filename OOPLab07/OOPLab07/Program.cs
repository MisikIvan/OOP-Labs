using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace lab6
{
    internal class Program
    {
        static Product[] ReadProductsArray()
        {
            Console.Clear();
            Console.WriteLine("Введіть кількість елементів масиву: ");
            bool p;
            int n;
            do
            {
                p = int.TryParse(Console.ReadLine(), out n);
                if (!p)
                {
                    Console.Write("Введіть ціле число ");
                }
                if (n < 1)
                {
                    Console.WriteLine(" n не може бути меньше 1");
                    p = false;
                }
            } while (!p);
            Product[] masiv = new Product[n];
            for (int i = 0; i < n; i++)
            {
                masiv[i] = new Product();
                Console.WriteLine("Введіть назву товару");
                masiv[i].Name = Console.ReadLine();
                Console.WriteLine("Вартість одиниці товару");
                do
                {
                    p = double.TryParse(Console.ReadLine(), out masiv[i].Price);
                    if (masiv[i].Price < 0)
                    {
                        p = false;
                    }
                    if (!p)
                    {
                        Console.WriteLine("Помилка введення");
                    }
                } while (!p);
                Console.WriteLine("Введіть назву валюти:");
                masiv[i].Cost.Name = Console.ReadLine();
                Console.WriteLine("Введіть курс валюти:");
                do
                {
                    p = double.TryParse(Console.ReadLine(), out masiv[i].Cost.ExRate);
                    if (masiv[i].Cost.ExRate < 0)
                    {
                        p = false;
                    }
                    if (!p)
                    {
                        Console.WriteLine("Помилка вводу");
                    }
                } while (!p);
                Console.WriteLine("Введіть кількість наявних товарів на складі");
                do
                {
                    p = int.TryParse(Console.ReadLine(), out masiv[i].Quantity);
                    if (masiv[i].Quantity < 0)
                    {
                        p = false;
                    }
                    if (!p)
                    {
                        Console.WriteLine("Помилка вводу");
                    }
                } while (!p);
                Console.WriteLine("Введіть компанії-виробника:");
                masiv[i].Producer = Console.ReadLine();
                Console.WriteLine("Введіть вагу одиниці товару:");
                do
                {
                    p = double.TryParse(Console.ReadLine(), out masiv[i].Weight);
                    if (masiv[i].Weight < 0)
                    {
                        p = false;
                    }
                    if (!p)
                    {
                        Console.WriteLine("Помилка вводу");
                    }
                } while (!p);
            }
            return masiv;
            Console.Clear();
        }
        static void PrintProduct(Product prod, Product [] m)
        {
            Console.WriteLine($"Назва товару:{prod.GetName()}" +
                $"\nВартість одиниці товару по курсу:{ prod.GetPrice()}" +
                $"\nНазва валюти:{prod.GetCost().GetName()}" +
                $"\nКурс валюти:{prod.GetCost().GetExRate()}" +
                $"\nКількість наявних товарів на складі:{prod.GetQuantity()}" +
                $"\nНазва компанії-виробника:{prod.GetProducer()}" +
                $"\nВага одиниці товару:{prod.GetWeight()}" +
                $"\nЗагальна вартість товару на складі:{prod.GetTotalPriceInUAH(prod,m)}" +
                $"\nЗагальна вага товару на складі:{prod.GetTotalWeight(prod,m)}");
        }
        static void PrintProducts(Product []prod)
        {
            for (int i = 0; i < prod.Length;i++)
            {
                Console.Write($"{i+1}.");
                PrintProduct(prod[i], prod);
                Console.WriteLine("");
            }
        }
        static void GetProductsInfo(Product []prod, out double maxcina, out double mincina)
        {
             maxcina = -99999999;
             mincina = 9999999;
            for (int i = 0; i < prod.Length; i++)
            {
                double tmp = prod[i].GetPriceInUAH();
                if (maxcina < tmp)
                {
                    maxcina = tmp;
                }
                if (mincina > tmp)
                {
                    mincina = tmp;
                }
            }
        }
        static void SortProductsByPrice(Product []prod)
        {
            Product[] tmp = new Product[prod.Length];
            for (int i=0; i<prod.Length;i++)
            {
                 tmp[i] = new Product(prod[i]);
            }
            Array.Sort(tmp, sort);
            PrintProducts(tmp);
        }
        static int sort(Product x1, Product x2)
        {
            double tx1 = x1.GetPriceInUAH(), tx2 = x2.GetPriceInUAH();
            if (tx1 > tx2)
            {
                return 1;
            }
            if (tx1 < tx2)
            {
                return -1;
            }
            return 0;
        }
        static void SortProductsByCount(Product[] prod)
        {
            Product[] tmp = new Product[prod.Length];
            for (int i = 0; i < prod.Length; i++)
            {
                tmp[i] = new Product(prod[i]);
            }
            Array.Sort(tmp, sort2);
            PrintProducts(tmp);
        }
        static int sort2(Product x1, Product x2)
        {
            int tx1 = x1.Quantity, tx2 = x2.Quantity;
            if (tx1 > tx2)
            {
                return 1;
            }
            if (tx1 < tx2)
            {
                return -1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Лабораторна робота №6 Охремчук.Є.М. КБ-21-2";
            Product[] masiv;
            masiv = ReadProductsArray();
            Console.Clear();
            int menu;
            bool p;
            do
            {
                Console.WriteLine("1-Виведення інформації\n2-Найдешевший та найдорожчий товари\n3-Сортування за зростанням ціни\n4-Сортування за кількістю товарів на складі\n5-Новий масив\n0-Вихід");
                do
                {
                    p = int.TryParse(Console.ReadLine(), out menu);
                    if (!p)
                    {
                        Console.WriteLine("Помилка введення");
                    }
                } while (!p);
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Вивести інформацію про один товар-1 про всі товари-2");
                        int podm;
                        do
                        {
                            p = int.TryParse(Console.ReadLine(), out podm);
                            if (!p)
                            {
                                Console.WriteLine("Помилка введення");
                            }
                        } while (!p);
                        switch (podm)
                        {
                            case 1:
                                Console.Clear();
                                int n;
                                Console.WriteLine($"Оберіть номер товару, про який вивести інформацію. Від 1 до {masiv.Length}");
                                do
                                {
                                    p = int.TryParse(Console.ReadLine(), out n);
                                    if (n < 1 || n > masiv.Length)
                                    {
                                        p = false;
                                    }
                                    if (!p)
                                    {
                                        Console.WriteLine("Помилка введення");
                                    }
                                } while (!p);
                                PrintProduct(masiv[n-1], masiv);
                                break;
                            case 2:
                                Console.Clear();
                                PrintProducts(masiv);
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        double mincina, maxcina;
                        GetProductsInfo(masiv, out maxcina, out mincina);
                        Console.WriteLine($"Найдорожчий товар:{maxcina}\nНайдешевший товар:{mincina}");
                        break;
                    case 3:
                        Console.Clear();
                        SortProductsByPrice(masiv);
                        break;
                    case 4:
                        Console.Clear();
                        SortProductsByCount(masiv);
                        break;
                    case 5:
                        Console.Clear();
                        masiv = null;
                        masiv = ReadProductsArray();
                        break;
                }
            } while (menu != 0);
        }
    }
}

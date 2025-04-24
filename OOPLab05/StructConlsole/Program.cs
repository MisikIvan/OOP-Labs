using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructConlsole
{
    class Program
    {
        public struct Currency
        {
            public string Name;
            public double ExRate;
            public Currency(string name, double exrate)
            {
                Name = name;
                ExRate = exrate;
            }
        }

        public struct Product
        {
            public string Name;
            public int Price;
            public Currency[] Cost;
            public int Quantity;
            public string Producer;
            public double Weight;
            public Product(string name, int price, Currency[] cost, int quantity, string producer, double weight)
            {
                Name = name;
                Price = price;
                Cost = cost;
                Quantity = quantity;
                Producer = producer;
                Weight = weight;
            }
            public Product(Product obj)
            {
                Name = obj.Name;
                Price = obj.Price;
                Cost = obj.Cost;
                Quantity = obj.Quantity;
                Producer = obj.Producer;
                Weight = obj.Weight;
            }
            public double GetPriceInUAH()
            {
                double priceInUAH = 0;
                for (int i = 0; i < Cost.Length; i++)
                {
                    if (1< Cost[i].ExRate)
                    priceInUAH = Price * Cost[i].ExRate;
                }
                return priceInUAH;
            }
            public double GetTotalPriceInUAH(Product prod, Product[] m)
            {
                double totalPriceInUAH = 0;
                for (int i = 0; i < m.Length; i++)
                {
                    if (prod.Name == m[i].Name)
                    {
                        totalPriceInUAH += m[i].GetPriceInUAH() * m[i].Quantity;
                    }
                }
                return totalPriceInUAH;
            }
            public double GetTotalWeight(Product prod, Product[] m)
            {
                double totalweight = 0;
                for (int i = 0; i < m.Length; i++)
                {
                    if (prod.Name == m[i].Name)
                    {
                        totalweight += m[i].Quantity * m[i].Weight;
                    }
                }
                return totalweight;
            }
        }
        static Product[] ReadProductsArray()
        {
            int n;
            Console.WriteLine("Введіть кількість елементів масиву: ");
            n = int.Parse(Console.ReadLine());
            Product[] masiv = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Назва товару: "); masiv[i].Name = Console.ReadLine();
                Console.Write("Ціна за одиницю товару: "); masiv[i].Price = int.Parse(Console.ReadLine());
                masiv[i].Cost = new Currency[1];
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("Назва валюти: "); masiv[i].Cost[j].Name = Console.ReadLine();
                    Console.Write("Курс валюти: "); masiv[i].Cost[j].ExRate = double.Parse(Console.ReadLine());
                }
                Console.Write("Кількість наявних товарів на складу: "); masiv[i].Quantity = int.Parse(Console.ReadLine());
                Console.Write("Назва компанії-виробника: "); masiv[i].Producer = Console.ReadLine();
                Console.Write("Вага одиниці товару: "); masiv[i].Weight = double.Parse(Console.ReadLine());
            }
            return masiv;
        }
        static void PrintProduct(Product prod, Product[] m)
        {
            Console.WriteLine($"Назва товару: {prod.Name}");
            Console.WriteLine($"Ціна за одиницю товару: {prod.Price}");
            for (int j = 0; j < prod.Cost.Length; j++)
            {
                Console.WriteLine($"Назва валюти: {prod.Cost[j].Name}");
                Console.WriteLine($"Курс валюти: {prod.Cost[j].ExRate}");
            }
            Console.WriteLine($"Кількість наявних товарів на складу: {prod.Quantity}");
            Console.WriteLine($"Назва компанії-виробника: {prod.Producer}");
            Console.WriteLine($"Вага одиниці товару: {prod.Weight}");
            Console.WriteLine($"Вартість одиниці товару: { prod.GetPriceInUAH()}");
            Console.WriteLine($"Загальна вартість товару на складі: { prod.GetTotalPriceInUAH(prod, m)} ");
            Console.WriteLine($"Загальна вага товару на складі: {prod.GetTotalWeight(prod, m)}");
        }
        static void PrintProducts(Product[] prod)
        {
            for (int i = 0; i < prod.Length; i++)
            {
                Console.Write($"{i + 1}.");
                PrintProduct(prod[i], prod);
                Console.WriteLine("");
            }
        }
        static void GetProductsInfo(Product[] prod, out double maxcina, out double mincina)
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
       
        static void SortProductsByPrice(Product[] prod)
        {
            Product[] tmp = new Product[prod.Length];
            for (int i = 0; i < prod.Length; i++)
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
            Console.Title = "Лабораторна робота №5";
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
                                PrintProduct(masiv[n - 1], masiv);
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
                        Console.WriteLine($"Найдорожчий товар:{maxcina} UAH\nНайдешевший товар:{mincina} UAH");
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

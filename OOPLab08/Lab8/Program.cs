using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary;

namespace Lab8
{
    internal class Program
    {
        public static Human pepl = new Human();
        static void ShowFullInfo(List<Human> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Show();
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            System.Globalization.CultureInfo customCulture =
           (System.Globalization.CultureInfo)
           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            customCulture.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.Title = "Лабораторна робота №8";
            List<Human> list = new List<Human>();
            int n;
            bool flag = false;
            do
            {
                Console.WriteLine("1 - Людина\n2 - Абітурієнт\n3 - Студент\n4 - Викладач\n5 - Користувач бібліотеки\n6 - Вивести інформацію з всіх класів\n0 - Вийти");

                Console.WriteLine("Оберіть клас:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        {
                            Console.Clear();
                            flag = true;
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Human human = new Human(name: "", surname: "", date: "");
                            pepl.Write();
                            Console.WriteLine("\nРезультат\n");
                            pepl.Show();
                            list.Add(pepl);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Applicant applicant = new Applicant(name: "", surname: "",
                            date: "", points: 0, atestat: 0, Nameofschool: "");
                            applicant.Write();
                            Console.WriteLine("\nРезультат\n");
                            applicant.Show();
                            list.Add(applicant);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Student student = new Student(name: "", surname: "", date:
                           "", course: 0, group: "", facultet: "", university: "");
                            student.Write();
                            Console.WriteLine("\nРезультат\n");
                            student.Show();
                            list.Add(student);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Teacher teacher = new Teacher(name: "", surname: "", date:
                           "", position: "", department: "", university: "");
                            teacher.Write();
                            Console.WriteLine("\nРезультат\n");
                            teacher.Show();
                            list.Add(teacher);
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            LibraryUser libuser = new LibraryUser(name: "", surname: "",
                           date: "", ticket: 0, dateofissue: 0, fee: 0);
                            libuser.Write();
                            Console.WriteLine("\nРезультат\n");
                            libuser.Show();
                            list.Add(libuser);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            ShowFullInfo(list);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Невірно введено число!");
                            break;
                        }
                }
            } while (!flag);
            Console.ReadKey();
        }
    }
}

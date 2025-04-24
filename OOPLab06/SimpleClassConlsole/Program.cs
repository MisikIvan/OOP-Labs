using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimpleClassConsole
{
    internal class Program
    {
        class Result
        {
            protected string Subject;
            protected string Teacher;
            protected float Points;
            public Result(string subject, string teacher, float points) // Конструктор екземплярів
            {
                Subject = subject;
                Teacher = teacher;
                Points = points;
            }
            public Result(Result result) //Конструктор копіювання
            {
                Subject = result.Subject;
                Teacher = result.Teacher;
                Points = result.Points;
            }
            public Result()
            {
            }
            public void SetSubject(string subject)
            {
                if (subject.Length > 0)
                {
                    Subject = subject;
                }
                else Console.WriteLine("Wrong Subject");
            }
            public void SetTeacher(string teacher)
            {
                if (teacher.Length > 0)
                {
                    Teacher = teacher;
                }
                else Console.WriteLine("Wrong Teacher");
            }
            public void SetPoints(float points)
            {
                if (points > 0)
                {
                    Points = points;
                }
                else Console.WriteLine("Wrong Points");
            }
            public string GetSubject()
            {
                return Subject;
            }
            public string GetTeacher()
            {
                return Teacher;
            }
            public float GetPoints()
            {
                return Points;
            }
        }
        class Student
        {
            protected string FirstName;
            protected string Surname;
            protected string Group;
            protected int Year;
            protected Result[] Results = new Result[100];
            public Student(string firstname, string surname, string group, int year) // Конструктор екземплярів
            {
                FirstName = firstname;
                Surname = surname;
                Group = group;
                Year = year;
            }
            public Student(Student student) // Конструктор копіювання
            {
                FirstName = student.FirstName;
                Surname = student.Surname;
                Group = student.Group;
                Year = student.Year;
            }
            public Student()
            {
            }
            public void SetFirstName(string firstname)
            {
                if (firstname.Length > 0)
                {
                    FirstName = firstname;
                }
                else Console.WriteLine("Wrong FirstName");
            }
            public void SetSurname(string surname)
            {
                if (surname.Length > 0)
                {
                    Surname = surname;
                }
                else Console.WriteLine("Wrong Surname");
            }
            public void SetGroup(string group)
            {
                if (group.Length > 0)
                {
                    Group = group;
                }
                else Console.WriteLine("Wrong Group");
            }
            public void SetYear(int year)
            {
                if (year > 0)
                {
                    Year = year;
                }
                else Console.WriteLine("Wrong Year");
            }
            public void SetResults(Result[] results)
            {
                for (int i = 0; i < results.Length; i++)
                {
                    if (results[i].GetSubject().Length > 0 &&
                   results[i].GetTeacher().Length > 0 && results[i].GetPoints() > 0)
                    {
                        Results = results;
                    }
                    else Console.WriteLine("Wrong Results");
                }
            }
            public string GetFirstName()
            {
                return FirstName;
            }
            public string GetSurname()
            {
                return Surname;
            }
            public string GetGroup()
            {
                return Group;
            }
            public int GetYear()
            {
                return Year;
            }
            public Result[] GetResults()
            {
                return Results;
            }
            public float GetAveragePoints()
            {
                float averagePoints = 0;
                for (int i = 0; i < GetResults().Length; i++)
                {
                    averagePoints += GetResults()[i].GetPoints();
                }
                return averagePoints / GetResults().Length;
            }
            public string GetBestSubject()
            {
                float max = float.MinValue;
                string maxValue = "";
                for (int i = 0; i < GetResults().Length; i++)
                {
                    if (GetResults()[i].GetPoints() > max)
                    {
                        maxValue = GetResults()[i].GetSubject();
                        max = GetResults()[i].GetPoints();
                    }
                }
                return maxValue;
            }
            public string GetWorstSubject()
            {
                float min = float.MaxValue;
                string minValue = "";
                for (int i = 0; i < GetResults().Length; i++)
                {
                    if (GetResults()[i].GetPoints() < min)
                    {
                        minValue = GetResults()[i].GetSubject();
                        min = GetResults()[i].GetPoints();
                    }
                }
                return minValue;
            }
        }
        static Student ReadStudentsArray()
        {
            Student student = new Student();
            Console.WriteLine("\nВведіть Ім'я : ");
            student.SetFirstName(Console.ReadLine());
            Console.WriteLine("Введіть Прізвище : ");
            student.SetSurname(Console.ReadLine());
            Console.WriteLine("Введіть назву групи : ");
            student.SetGroup(Console.ReadLine());
            Console.WriteLine("Введіть рік народження: ");
            int a;
            while (!Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Невірно введено значення! Спробуйте ще раз!");
            }
            student.SetYear(a);
            Console.WriteLine("Кількість предметів, що студент здав : ");
            int num;
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Невірно введено значення! Спробуйте ще раз!");
            }
            Result[] results = new Result[num];
            for (int i = 0; i < num; i++)
            {
                results[i] = new Result();
                Console.WriteLine($"\n\nSubject #{i + 1}");
                Console.WriteLine("Назва пердмета : ");
                results[i].SetSubject(Console.ReadLine());
                Console.WriteLine("ПІБ вчителя : ");
                results[i].SetTeacher(Console.ReadLine());
                Console.WriteLine("Оцінка : ");
                int c;
                while (!Int32.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Невірно введено значення! Спробуйте ще раз!");
                }
                results[i].SetPoints(c);
            }
            student.SetResults(results);
            return student;
        }
        static void PrintStudent(Student student)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"\nІм'я : {student.GetFirstName()}");
            Console.WriteLine($"Прізвище :{student.GetSurname()} ");
            Console.WriteLine($"Назва групи : {student.GetGroup()}");
            Console.WriteLine($"Рік народження: {student.GetYear()}");
            for (int i = 0; i < student.GetResults().Length; i++)
            {
                Console.WriteLine($"\nSubject #{i + 1}");
                Console.WriteLine($"Назва предмета : { student.GetResults()[i].GetSubject()}");
                Console.WriteLine($"ПІБ вчителя : { student.GetResults()[i].GetTeacher()}");
                Console.WriteLine($"Оцінка : {student.GetResults()[i].GetPoints()}");
            }
            Console.WriteLine($"\nСереднє арифметичне для студента : { student.GetAveragePoints()}");
            Console.WriteLine($"\nПредмет з найменшою оцінкою : { student.GetWorstSubject()}");
            Console.WriteLine($"\nПредмет з найбільшою оцінкою : { student.GetBestSubject()}");
 }
        static void PrintStudents(Student[] students)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("----Дані {0}----", i + 1);
                Console.WriteLine($"\nІм'я : {students[i].GetFirstName()}");
                Console.WriteLine($"Прізвище :{students[i].GetSurname()} ");
                Console.WriteLine($"Назва групи : {students[i].GetGroup()}");
                Console.WriteLine($"Рік народження: {students[i].GetYear()}");
                for (int j = 0; j < students[i].GetResults().Length; j++)
                {
                    Console.WriteLine($"\nSubject #{j + 1}");
                    Console.WriteLine($"Назва предмета : { students[i].GetResults()[j].GetSubject()}");
                    Console.WriteLine($"ПІБ вчителя : { students[i].GetResults()[j].GetTeacher()}");
                    Console.WriteLine($"Оцінка : { students[i].GetResults()[j].GetPoints()}");
                }
                Console.WriteLine($"\nСереднє арифметичне для студента #{i + 1} : { students[i].GetAveragePoints()}");
                Console.WriteLine($"\nПредмет з найменшою оцінкою студента #{i + 1} : { students[i].GetWorstSubject()}");
                Console.WriteLine($"\nПредмет з найбільшою оцінкою студента #{i + 1} : { students[i].GetBestSubject()}");
            }
        }
        static void GetStudentsInfo(Student[] students, out float minavg, out float
       maxavg)
        {
            maxavg = float.MinValue;
            minavg = float.MaxValue;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GetAveragePoints() > maxavg)
                {
                    maxavg = students[i].GetAveragePoints();
                }
                if (students[i].GetAveragePoints() < minavg)
                {
                    minavg = students[i].GetAveragePoints();
                }
            }
        }
        static int SortTypePoints(Student a, Student b)
        {
            int c = 1;
            if (a.GetAveragePoints() > b.GetAveragePoints()) return 1;
            if (a.GetAveragePoints() < b.GetAveragePoints()) { c = -1; return c; }
            return 0;
        }
        static int SortTypeName(Student a, Student b)
        {
            int c = 1;
            if (String.Compare(a.GetSurname(), b.GetSurname()) > 0) return 1;
            if (String.Compare(a.GetSurname(), b.GetSurname()) < 0) { c = -1; return c; }
            if (String.Compare(a.GetSurname(), b.GetSurname()) == 0)
            {
                if (String.Compare(a.GetFirstName(), b.GetFirstName()) > 0) return 1;
                if (String.Compare(a.GetFirstName(), b.GetFirstName()) < 0)
                {
                    c = -1;
                    return c;
                }
            }
            return 0;
        }
        static void SortStudentsByPoints(Student[] students)
        {
            Array.Sort(students, SortTypePoints);
            Console.WriteLine("\nЗростаюче сортування по середній оцінці:\n");
            PrintStudents(students);
        }
        static void SortStudentsByName(Student[] students)
        {
            Array.Sort(students, SortTypeName);
            Console.WriteLine("\nЗростаюче сортування по прізвищу :\n");
            PrintStudents(students);
        }
        static void Menu(Student[] students)
        {
            int a, b;
            Console.WriteLine("1 - Ввести дані про студентів \n2 - Вивести дані потрібного студента \n3 - Вивести дані всіх студентів \n4 - Найвищий та найнижчій середній бал\n5 - Сортування студентів за середнім балом \n6 - Сортування студентів за прізвищем");
        while (!Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Невірно введено значення. Спробуйте ще раз!");
            }
            switch (a)
            {
                case 1:
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("\n----Дані {0}----", i + 1);
                        students[i] = ReadStudentsArray();
                    }
                    Pause();
                    Menu(students);
                    break;
                case 2:
                    Console.WriteLine("Номер студента ?");
                    while (!Int32.TryParse(Console.ReadLine(), out b) && b >= 0 &&
                   b <= students.Length)
                    {
                        Console.WriteLine("Невірно введено значення. Спробуйте ще раз!");
                    }
                    PrintStudent(students[b - 1]);
                    Pause();
                    Menu(students);
                    break;
                case 3:
                    PrintStudents(students);
                    Pause();
                    Menu(students);
                    break;
                case 4:
                    float minavg, maxavg;
                    GetStudentsInfo(students, out minavg, out maxavg);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\nМаксимальне середнє арифметичне = {maxavg} \nМінімальне середнє арифметичне = { minavg}");
                    Pause();
                    Menu(students);
                    break;
                case 5:
                    SortStudentsByPoints(students);
                    Pause();
                    Menu(students);
                    break;
                case 6:
                    SortStudentsByName(students);
                    Pause();
                    Menu(students);
                    break;
                default:
                    Console.WriteLine("Такої цифри не має в меню. Спробуйте ще раз!");
                    Pause();
                    Menu(students);
                    break;
            }
        }
        static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nНатисніть на будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Title = "Лабораторна робота №6";
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть кількість студентів, чию інформацію ви хочете додати");
            int num;
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Число введено невірно. Спробуйте ще раз!");
            }
            Student[] student = new Student[num];
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Menu(student);
        }
    }
}
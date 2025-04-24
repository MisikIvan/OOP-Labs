using System;

namespace ClassLibrary
{
    public class Student : Human
    {
        protected int Course;
        protected string Group;
        protected string Fac;
        protected string University;
        public Student(string name, string surname, string date, int course, string
       group, string facultet, string university) : base(name, surname, date)
        {
            Course = course;
            Group = group;
            Fac = facultet;
            University = university;
        }
        public Student(string name, string surname, string date, int course, string group, string facultet) : base(name, surname, date)
        {
            Group = group;
            Course = course;
            Fac = facultet;
        }
        public Student(Student obj) : base(obj)
        {
            Course = obj.Course;
            Group = obj.Group;
            Fac = obj.Fac;
            University = obj.University;
        }
        public override void Print()
        {
            Console.WriteLine($"Курс: {Course}\nГрупа: {Group}\nФакультет: {Fac}\nНавч.заклад: { University} ");
        }
        public override void Write()
        {
            base.Write();
            bool ok;
            Console.WriteLine("Курс:");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out Course);
                if (Course < 1 || Course > 5)
                {
                    Console.WriteLine("Помилка. Введіть ще раз! Від 1 до 5");
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("Група:");
            Group = Console.ReadLine();
            Console.WriteLine("Факультет:");
            Fac = Console.ReadLine();
            Console.WriteLine("Навч.заклад:");
            University = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine($"Студент :\n\nІм'я: {Name}\nПрізвище: {Surname}\nДата народження: { Date}\nКурс: { Course}\nГрупа: { Group}\nФакультет: { Fac}\nУніверситет: { University}");
        }
    }
}

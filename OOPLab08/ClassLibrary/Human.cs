using System;

namespace ClassLibrary
{
    public class Human
    {
        public string Name;
        public string Surname;
        public string Date;
        public Human()
        {
            Name = "-";
            Surname = "-";
            Date = "-";
        }
        public Human(string name, string surname, string date)
        {
            Name = name;
            Surname = surname;
            Date = date;
        }
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Human(Human obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Date = obj.Date;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Ім'я: {Name}\nПрізвище: {Surname}\nДата народження: {Date}\n");
        }
        public virtual void Write()
        {
            Console.WriteLine("Ім'я:");
            Name = Console.ReadLine();
            Console.WriteLine("Прізвище:");
            Surname = Console.ReadLine();
            Console.WriteLine("Дата народження:");
            Date = Console.ReadLine();
        }
        public virtual void Show()
        {
            Console.WriteLine($"Людина :\n\nІм'я: {Name}\nПрізвище: {Surname}\nДата народження: { Date}\n");
        }
    }

}

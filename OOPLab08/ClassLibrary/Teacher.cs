using System;

namespace ClassLibrary
{
    public class Teacher : Human
    {
        string Position;
        string Department;
        string University;
        public Teacher(string name, string surname, string date, string position, string
        department, string university) : base(name, surname, date)
        {
            Position = position;
            Department = department;
            University = university;
        }
        public Teacher(string name, string surname, string position, string department) :
       base(name, surname)
        {
            Position = position;
            Department = department;
        }
        public Teacher(Teacher obj) : base(obj)
        {
            Position = obj.Position;
            Department = obj.Department;
            University = obj.University;
        }
        public override void Print()
        {
            Console.WriteLine($"Посада: {Position}\nКафедра: {Department}\nНавч.заклад: {University}\n");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Посада:");
            Position = Console.ReadLine();
            Console.WriteLine("Кафедра:");
            Department = Console.ReadLine();
            Console.WriteLine("Навч.заклад:");
            University = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine($"Вчителі :\n\nІм'я: {Name}\nПрізвище: {Surname}\nДата народження: { Date}\nПосада: { Position}\nКафедра: { Department}\nНавч.заклад: {University}\n");
        }
    }
}

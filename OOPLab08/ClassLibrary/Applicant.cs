using System;

namespace ClassLibrary
{
    public class Applicant : Human
    {
        public int Points;
        public int Atestat;
        public string NameOfSchool;
        public Applicant(string name, string surname, string date, int points, int
       atestat, string Nameofschool) : base(name, surname, date)
        {
            Points = points;
            Atestat = atestat;
            NameOfSchool = Nameofschool;
        }
        public Applicant(string name, string date, int points, int atestat) :
       base(name, date)
        {
            Points = points;
            Atestat = atestat;
        }
        public Applicant(Applicant obj) : base(obj)
        {
            Points = obj.Points;
            Atestat = obj.Atestat;
            NameOfSchool = obj.NameOfSchool;
        }
        public override void Print()
        {
            Console.WriteLine($"Кількість балів ЗНО: {Points}\nАтестат: { Atestat}\nНавчальний заклад: { NameOfSchool}\n");
        }
        public override void Write()
        {
            base.Write();
            bool ok;
            Console.WriteLine("Середній бал ЗНО:");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out Points);
                if (Points < 100 || Points > 200)
                {
                    Console.WriteLine("Помилка. Спробуйте ще раз! Від 100 до 200");
                   
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("Середній бал атестата:");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out Atestat);
                if (Atestat <= 0 || Atestat > 12)
                {
                    Console.WriteLine("Помилка. Спробуйте ще раз! Від 0 до 12");
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("Назва навч. закладу:");
            NameOfSchool = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine($"Абітурієнт :\n\nІм'я: {Name}\nПрізвище: { Surname}\nДата народження: { Date}\nЗно: { Points}\nАтестат: { Atestat}\nНавч.Заклад: { NameOfSchool}\n");
        }
    }
}

using System;

namespace ClassLibrary
{
    public class LibraryUser : Human
    {
        public int Ticket;
        public int DateOfIssue;
        public int Fee;
        public LibraryUser(string name, string surname, string date, int ticket, int
       dateofissue, int fee) : base(name, surname, date)
        {
            Ticket = ticket;
            DateOfIssue = dateofissue;
            Fee = fee;
        }
        public LibraryUser(string name, string surname, int ticket, int dateofissue) :
       base(name, surname)
        {
            Ticket = ticket;
            DateOfIssue = dateofissue;
        }
        public LibraryUser(LibraryUser obj) : base(obj)
        {
            Ticket = obj.Ticket;
            DateOfIssue = obj.DateOfIssue;
            Fee = obj.Fee;
        }
        public override void Print()
        {
            Console.WriteLine($"Номер чит.квитка: {Ticket}\nДата видачі: {DateOfIssue}\nЧитацький внесок: {Fee}");
        }
        public override void Write()
        {
            base.Write();
            bool ok;
            Console.WriteLine("Номер квитка:");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out Ticket);
                if (Ticket < 0)
                {
                    Console.WriteLine("Помилка. Спробуйте ще раз!");
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("Дата видачі:");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out DateOfIssue);
                if (DateOfIssue < 1 || DateOfIssue > 31)
                {
                    Console.WriteLine("Помилка. Спробуйте ще раз! Від 1 до 31");
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("Читацький внесок:");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out Fee);
                if (Fee < 0)
                {
                    Console.WriteLine("Помилка. Спробуйте ще раз!");
                    ok = false;
                }
            } while (!ok);
        }
        public override void Show()
        {
            Console.WriteLine($"Користувач бібліотеки :\n\nІм'я: {Name}\nПрізвище: { Surname}\nДата народження: { Date}\nНомер чит. квитка: { Ticket}\nДата видачі: {DateOfIssue}\nЧитацький внесок: { Fee}");
        }
    }

}

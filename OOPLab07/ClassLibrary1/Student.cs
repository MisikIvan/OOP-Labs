using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class Student
    {
        protected string FirstName;
        protected string Surname;
        protected string Group;
        protected int Year;
        protected int Price;
        protected Result[] Results = new Result[100];
        public Student(string firstname, string surname, string group, int year, int price) // Конструктор екземплярів
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
            Price = student.Price;
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
        public void SetPriceforMonth(int price)
        {
            if (price > 0)
            {
                Price = price;
            }
            else Console.WriteLine("Wrong Price");
        }
        public int GetPriceforMonth()
        {
            return Price;
        }
        public int GetPriceforYear()
        {
            return GetPriceforMonth() * 10;
        }
        public int GetPriceforAllTime()
        {
            return GetPriceforYear() * 4;
        }

    }
}

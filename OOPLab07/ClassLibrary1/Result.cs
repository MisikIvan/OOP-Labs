using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class Result
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
}

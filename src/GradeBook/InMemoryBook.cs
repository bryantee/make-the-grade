using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class InMemoryBook : Book
    {
        private readonly List<double> _grades;

        public InMemoryBook(string name, string category = "") : base(name, category)
        {
            Name = name;
            _grades = new List<double>();
        }

        public override void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                _grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}. Must be between 1 and 100.");
            }
        }

        public List<double> GetGrades() => _grades;

        public override Statistics GetStats() =>new Statistics(_grades);
        
        public override void ShowStats()
        {
            var stats = GetStats();

            Console.WriteLine($"The average is: {stats.Average:N2}");
            Console.WriteLine($"The highest grade is: {stats.High:N2}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }

        public override void ShowName()
        {
            Console.WriteLine($"Book name is: {Name}");
        }
    }
}
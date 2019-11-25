using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private readonly List<double> _grades;
        public string Name;

        public Book(string name)
        {
            Name = name;
            _grades = new List<double>();
        }
        
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                _grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Grade of {grade} is not valid. Must be between 0 and 100");
            }

        }

        public List<double> GetGrades() => _grades;

        public Statistics GetStats()
        {
            return new Statistics {High = CalculateMax(), Low = CalculateMin(), Average = CalculateAvg()};
        }

        public void ShowStats()
        {
            var stats = GetStats();

            Console.WriteLine($"The average is: {stats.Average:N2}");
            Console.WriteLine($"The highest grade is: {stats.High:N2}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
        }

        public void ShowName()
        {
            Console.WriteLine($"Book name is: {Name}");
        }

        private double CalculateMin()
        {
            return _grades.Min();
        }

        private double CalculateMax()
        {
            return _grades.Max();
        }

        private double CalculateAvg()
        {
            return _grades.Average();
        }
    }
}
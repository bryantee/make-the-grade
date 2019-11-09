using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private readonly List<double> _grades;
        private readonly string _name;

        public Book(string name)
        {
            this._name = name;
            _grades = new List<double>();
        }
        
        public void AddGrade(double grade)
        {
            _grades.Add(grade);
        }

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
            Console.WriteLine($"Book name is: {_name}");
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
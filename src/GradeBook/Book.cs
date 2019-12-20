#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private readonly List<double> _grades;
        public string Name { get; set; }

        private readonly string _category;

        public Book(string name, string? category = "")
        {
            Name = name;
            _grades = new List<double>();
            _category = category;
        }

        public void AddLetterGrade(char letter)
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

        public void AddGrade(double grade)
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

        public Statistics GetStats()
        {
            return new Statistics
            {
                High = CalculateMax(),
                Low = CalculateMin(),
                Average = CalculateAvg(),
                Letter = CalculateLetterGrade()
            };
        }

        public void ShowStats()
        {
            var stats = GetStats();

            Console.WriteLine($"The average is: {stats.Average:N2}");
            Console.WriteLine($"The highest grade is: {stats.High:N2}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }

        public void ShowName()
        {
            Console.WriteLine($"Book name is: {Name}");
        }


        public void ShowCategory()
        {
            if (!string.IsNullOrEmpty(_category))
            {
                Console.WriteLine($"The category is: {_category}");
            }
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

        private char CalculateLetterGrade()
        {
            var average = CalculateAvg();

            return average switch
            {
                var d when d >= 90.0 => 'A',
                var d when d >= 80.0 => 'B',
                var d when d >= 70.0 => 'C',
                var d when d >= 60.0 => 'D',
                _ => 'F'
            };
        }
    }
}
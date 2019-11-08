using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats()
        {
            var highestGrade = CalculateMax();
            var lowestGrade = CalculateMin();
            var averageGrade = CalculateAvg();

            Console.WriteLine($"The average is: {averageGrade:N2}");
            Console.WriteLine($"The highest grade is: {highestGrade:N2}");
            Console.WriteLine($"The lowest grade is: {lowestGrade:N2}");
        }

        private double CalculateMin()
        {
            return grades.Min();
        }

        private double CalculateMax()
        {
            return grades.Max();
        }

        private double CalculateAvg()
        {
            return grades.Average();
        }
    }
}
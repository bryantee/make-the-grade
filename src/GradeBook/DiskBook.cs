using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace GradeBook
{
    public class DiskBook : Book
    {
        private readonly string _fileName;

        public DiskBook(string bookName, string category = "") : base(bookName, category)
        {
            _fileName = $"{bookName}.gradebook.txt";
            
            Console.WriteLine("File location: {0}", FileSystem.CurrentDirectory);
            Console.WriteLine("Current file: {0}", _fileName);
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                using (var streamWriter = File.AppendText(_fileName))
                {
                    streamWriter.WriteLine(grade.ToString(CultureInfo.InvariantCulture));
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}. Must be between 1 and 100.");
            }
        }

        public List<double> GetGrades()
        {
            var grades = new List<double> { };

            using (var streamReader = File.OpenText(_fileName))
            {
                var line = streamReader.ReadLine();

                while (line != null)
                {
                    var grade = double.Parse(line);
                    grades.Add(grade);
                    line = streamReader.ReadLine();
                }
            }

            return grades;
        }

        public override Statistics GetStats() => new Statistics(GetGrades());

        public override void ShowName()
        {
            Console.WriteLine($"Book name is: {Name}");
        }

        public override void ShowStats()
        {
            var stats = GetStats();

            Console.WriteLine($"The average is: {stats.Average:N2}");
            Console.WriteLine($"The highest grade is: {stats.High:N2}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }

        public override void AddLetterGrade(char letter)
        {
            throw new NotImplementedException();
        }
    }
}
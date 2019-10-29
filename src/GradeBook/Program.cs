using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>(){ 12.7, 19, 25.25, 79 };
            var result = 0.00;
            
            foreach (double grade in grades)
            {
                result += grade;
            }

            var average = result / grades.Count();
            
            Console.WriteLine($"The average is: {average:N2}");
        }
    }
}
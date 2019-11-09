using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Tommy's grade book");
            book.AddGrade(72.4);
            book.AddGrade(90);
            book.AddGrade(98);
            book.AddGrade(64);
            book.ShowName();
            book.ShowStats();
        }
    }
}
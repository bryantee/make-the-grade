using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Tommy's grade book", "Science");
            var quit = false;

            while (quit != true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit:");
                var response = Console.ReadLine();
                if (response != null && !string.Equals(response.ToLower(), "q"))
                {
                    try
                    {
                        var parsedResponse = double.Parse(response);
                        book.AddGrade(parsedResponse);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    quit = true;
                }
            }

            book.ShowName();
            book.ShowCategory();
            book.ShowStats();
        }
    }
}
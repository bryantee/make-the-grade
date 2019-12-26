using System;

namespace GradeBook
{
    class Program
    {
        static void Main()
        {
            var book = new InMemoryBook("Tommy's grade book", "Science");

            EnterGrades(book);
            book.ShowName();
            book.ShowCategory();
            book.ShowStats();
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
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
                    finally
                    {
                        Console.WriteLine("**");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
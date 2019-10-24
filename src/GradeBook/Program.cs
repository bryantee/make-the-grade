using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length > 0 ? $"Hello, {args[0]}!" : "Hello World!");
        }
    }
}

#nullable enable
using System;

namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
        private readonly string? _category;

        protected Book(string name, string? category = "") : base(name)
        {
            _category = category;
        }
        
        public void ShowCategory()
        {
            if (!string.IsNullOrEmpty(_category))
            {
                Console.WriteLine($"The category is: {_category}");
            }
        }

        public abstract void AddGrade(double grade);
        public abstract Statistics GetStats();
        public abstract void ShowName();
        public abstract void ShowStats();
        public abstract void AddLetterGrade(char letter);
    }
}
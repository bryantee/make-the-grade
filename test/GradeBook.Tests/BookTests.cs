using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStatistics()
        {
            var book = new Book("");
            book.AddGrade(90.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            
            var result = book.GetStats();
            
            Assert.Equal(85.97, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}

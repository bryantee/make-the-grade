using System;
using System.Collections.Generic;
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

        [Fact]
        public void AddGradeWhenLessThan100AndGreaterThan0()
        {
            var book = new Book("");
            
            book.AddGrade(90);

            var grades = book.GetGrades();            
            
            Assert.Equal(new List<double>{90}, grades);
            Assert.Single(grades);
        }

        [Fact]
        public void NoGradeAddedWhenLessThan0()
        {
            var book = new Book("");
            
            book.AddGrade(-15.5);

            var grades = book.GetGrades();
            
            Assert.Empty(grades);
        }

        [Fact]
        public void NoGradeAddedWhenGreaterThan100()
        {
            var book = new Book("");
            
            book.AddGrade(395);

            var grades = book.GetGrades();
            
            Assert.Empty(grades);
        }
    }
}

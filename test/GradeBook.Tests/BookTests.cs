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
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void BookCalculatesStatisticsLetterGradeA()
        {
            var book = new Book("");
            book.AddGrade(90.1);

            var result = book.GetStats();

            Assert.Equal('A', result.Letter);
        }

        [Fact]
        public void BookCalculatesStatisticsLetterGradeB()
        {
            var book = new Book("");
            book.AddGrade(80.1);

            var result = book.GetStats();

            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void BookCalculatesStatisticsLetterGradeC()
        {
            var book = new Book("");
            book.AddGrade(70.1);

            var result = book.GetStats();

            Assert.Equal('C', result.Letter);
        }

        [Fact]
        public void BookCalculatesStatisticsLetterGradeD()
        {
            var book = new Book("");
            book.AddGrade(60.1);

            var result = book.GetStats();

            Assert.Equal('D', result.Letter);
        }

        [Fact]
        public void BookCalculatesStatisticsLetterGradeF()
        {
            var book = new Book("");
            book.AddGrade(50.1);

            var result = book.GetStats();

            Assert.Equal('F', result.Letter);
        }


        [Fact]
        public void AddGradeWhenLessThan100AndGreaterThan0()
        {
            var book = new Book("");

            book.AddGrade(90);

            var grades = book.GetGrades();

            Assert.Equal(new List<double> {90}, grades);
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

        [Fact]
        public void AddLetterGradeA()
        {
            var book = new Book("");

            book.AddLetterGrade('A');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {90}, grades);
        }

        [Fact]
        public void AddLetterGradeB()
        {
            var book = new Book("");

            book.AddLetterGrade('B');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {80}, grades);
        }

        [Fact]
        public void AddLetterGradeC()
        {
            var book = new Book("");

            book.AddLetterGrade('C');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {70}, grades);
        }

        [Fact]
        public void AddLetterGradeOther()
        {
            var book = new Book("");

            book.AddLetterGrade('Z');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {0}, grades);
        }
    }
}
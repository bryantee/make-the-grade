using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

/*
 * Because we're persisting data, these will likely need to implement
 * integration tests over isolated unit tests.
 */

namespace GradeBook.Tests
{
    public class DiskBookTests: IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly string _bookName = "John's gradebook";
        private readonly FileStream _tmpFile;

        public DiskBookTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _tmpFile = File.Create($"{_bookName}.gradebook.txt");
        }
        
        public void Dispose()
        {
            _tmpFile?.Dispose();
        }
        
        [Fact (Skip = "not implemented")]
        public void BookCalculatesStatistics()
        {
            var book = new DiskBook(_bookName);
            book.AddGrade(90.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.GetStats();

            Assert.Equal(85.97, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact (Skip = "not implemented")]
        public void BookCalculatesStatisticsLetterGradeA()
        {
            var book = new DiskBook(_bookName);
            book.AddGrade(90.1);

            var result = book.GetStats();

            Assert.Equal('A', result.Letter);
        }

        [Fact (Skip = "not implemented")]
        public void BookCalculatesStatisticsLetterGradeB()
        {
            var book = new DiskBook(_bookName);
            book.AddGrade(80.1);

            var result = book.GetStats();

            Assert.Equal('B', result.Letter);
        }

        [Fact (Skip = "not implemented")]
        public void BookCalculatesStatisticsLetterGradeC()
        {
            var book = new DiskBook(_bookName);
            book.AddGrade(70.1);

            var result = book.GetStats();

            Assert.Equal('C', result.Letter);
        }

        [Fact (Skip = "not implemented")]
        public void BookCalculatesStatisticsLetterGradeD()
        {
            var book = new DiskBook(_bookName);
            book.AddGrade(60.1);

            var result = book.GetStats();

            Assert.Equal('D', result.Letter);
        }

        [Fact (Skip = "not implemented")]
        public void BookCalculatesStatisticsLetterGradeF()
        {
            var book = new DiskBook(_bookName);
            book.AddGrade(50.1);

            var result = book.GetStats();

            Assert.Equal('F', result.Letter);
        }


        [Fact (Skip = "not implemented")]
        public void AddGradeWhenLessThan100AndGreaterThan0()
        {
            var book = new DiskBook(_bookName);

            book.AddGrade(90);

            var grades = book.GetGrades();

            Assert.Equal(new List<double> {90}, grades);
            Assert.Single(grades);
        }

        [Fact (Skip = "not implemented")]
        public void NoGradeAddedWhenLessThan0()
        {
            var book = new DiskBook(_bookName);

            try
            {
                book.AddGrade(-15.5);
            }
            catch (Exception ex)
            {
                _testOutputHelper.WriteLine(ex.Message);
            }

            var grades = book.GetGrades();

            Assert.Empty(grades);
        }

        [Fact (Skip = "not implemented")]
        public void NoGradeAddedWhenGreaterThan100()
        {
            var book = new DiskBook(_bookName);

            try
            {
                book.AddGrade(395);
            }
            catch (Exception ex)
            {
                _testOutputHelper.WriteLine(ex.Message);
            }

            var grades = book.GetGrades();

            Assert.Empty(grades);
        }

        [Fact (Skip = "not implemented")]
        public void AddLetterGradeA()
        {
            var book = new DiskBook(_bookName);

            book.AddLetterGrade('A');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {90}, grades);
        }

        [Fact (Skip = "not implemented")]
        public void AddLetterGradeB()
        {
            var book = new DiskBook(_bookName);

            book.AddLetterGrade('B');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {80}, grades);
        }

        [Fact (Skip = "not implemented")]
        public void AddLetterGradeC()
        {
            var book = new DiskBook(_bookName);

            book.AddLetterGrade('C');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {70}, grades);
        }

        [Fact (Skip = "not implemented")]
        public void AddLetterGradeOther()
        {
            var book = new DiskBook(_bookName);

            book.AddLetterGrade('Z');

            var grades = book.GetGrades();

            Assert.Single(grades);
            Assert.Equal(new List<double> {0}, grades);
        }
    }
}
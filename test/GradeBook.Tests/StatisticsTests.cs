using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace GradeBook.Tests
{
    public class StatisticsTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        private readonly List<double> _dummyStatusData = new List<double>()
        {
            90,
            95.5,
            79
        };

        public StatisticsTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void StatisticsCalculatesAverage()
        {
            var statistics = new Statistics(_dummyStatusData);

            Assert.Equal(88.17, statistics.Average, 1);
        }

        [Fact]
        public void StatisticsCalculatesHigh()
        {
            var statistics = new Statistics(_dummyStatusData);

            Assert.Equal(95.5, statistics.High, 1);
        }

        [Fact]
        public void StatisticsCalculatesLow()
        {
            var statistics = new Statistics(_dummyStatusData);

            Assert.Equal(79, statistics.Low, 1);
        }

        [Fact]
        public void StatisticsCalculatesLetterGradeA()
        {
            var averageGradesA = new List<double>() {90, 95, 97};
            var statistics = new Statistics(averageGradesA);

            Assert.Equal('A', statistics.Letter);
        }

        [Fact]
        public void StatisticsCalculatesLetterGradeB()
        {
            var averageGradesB = new List<double>() {80, 85, 90};
            var statistics = new Statistics(averageGradesB);

            Assert.Equal('B', statistics.Letter);
        }

        [Fact]
        public void StatisticsCalculatesLetterGradeC()
        {
            var averageGradesC = new List<double>() {70, 75, 76};
            var statistics = new Statistics(averageGradesC);

            Assert.Equal('C', statistics.Letter);
        }

        [Fact]
        public void StatisticsCalculatesLetterGradeD()
        {
            var averageGradesD = new List<double>() {65, 69, 59};
            var statistics = new Statistics(averageGradesD);

            Assert.Equal('D', statistics.Letter);
        }

        [Fact]
        public void StatisticsCalculatesLetterGradeF()
        {
            var averageGradesF = new List<double>() {50, 89, 25};
            var statistics = new Statistics(averageGradesF);

            Assert.Equal('F', statistics.Letter);
        }
    }
}
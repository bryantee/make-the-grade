using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Statistics
    {
        private readonly List<double> _scores;

        public Statistics(List<double> scores)
        {
            _scores = scores;
        }

        public double Average => _scores.Average();
        public double High => _scores.Max();
        public double Low => _scores.Min();
        
        public char Letter
        {
            get
            {
                return Average switch
                {
                    var d when d >= 90.0 => 'A',
                    var d when d >= 80.0 => 'B',
                    var d when d >= 70.0 => 'C',
                    var d when d >= 60.0 => 'D',
                    _ => 'F'
                };
            }
        }
    }
}
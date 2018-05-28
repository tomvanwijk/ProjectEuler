using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Puzzles.Puzzles
{
    public class Puzzle001 : IPuzzle
    {
        public string Title => "Multiples of 3 and 5.";
        public string Summary => "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23." + Environment.NewLine
                                    + "Find the sum of all the multiples of 3 or 5 below 1000.";

        public string Answer { get; private set; }


        public void SolvePuzzle()
        {
            Answer = (SumDivisibleBy(3) + SumDivisibleBy(5) - SumDivisibleBy(15)).ToString();
        }

        public int SumDivisibleBy(int divisor)
        {
            var p = 999 / divisor;
            return divisor * (p * (p + 1)) / 2;
        }
    }
}

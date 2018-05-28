using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles.Puzzles
{
    public class Puzzle003 : IPuzzle
    {
        public string Title => "Largest prime factory";
        public string Summary => "The prime factors of 13195 are 5, 7, 13 and 29. "+ Environment.NewLine
                                + "What is the largest prime factor of the number 600851475143 ?";
        public string Answer { get; private set; }
        public void SolvePuzzle()
        {
            var factors = GetPrimeFactors(600851475143);
            Answer = factors.Max().ToString();
        }

        private IList<long> GetPrimeFactors(long number)
        {
            var factors = new List<long>();
            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }

            if (number > 2)
                factors.Add(number);

            return factors;

        }
    }
}

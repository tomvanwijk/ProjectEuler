using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Puzzles.Puzzles;

namespace ProjectEuler.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Puzzle001_GetAnswer()
        {
            var puzzle = new Puzzle001();
            puzzle.SolvePuzzle();
            Assert.AreEqual("233168", puzzle.Answer);
        }

        [TestMethod]
        public void Puzzle001_TestSumDivisorFunction()
        {
            var puzzle = new Puzzle001();
            var actual = puzzle.SumDivisibleBy(3) + puzzle.SumDivisibleBy(5) - puzzle.SumDivisibleBy(15);
            Assert.AreEqual("233168", actual.ToString());
        }

        [TestMethod]
        public void Puzzle001_TestFunction()
        {
            var max = 22;
            var divisor = 2;
            var p = max / divisor;

            var y =  divisor * p * (p + 1) / 2;
            Assert.AreEqual(132,y);
        }

        [TestMethod]
        public void Puzzle002_GetAnswer()
        {
            var puzzle = new Puzzle002();
            puzzle.SolvePuzzle();
            var result = puzzle.Answer;
            Assert.AreEqual("4613732", result);
        }

        [TestMethod]
        public void Puzzle003_GetAnswer()
        {
            var puzzle = new Puzzle003();
            puzzle.SolvePuzzle();
            var result = puzzle.Answer;
            Assert.AreEqual("6857", result);
        }
    }
}

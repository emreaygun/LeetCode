using System;
using LeetQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LeetQuestionsTests
{
    [TestClass]
    public class Q1563_StoneGame5Test
    {
        Q1563_StoneGame5 problem = new Q1563_StoneGame5();

        [TestMethod]
        public void Test1()
        {
            var result = problem.Solve(new[] { 6, 2, 3, 4, 5, 5 });
            var expection = 18;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test2()
        {
            var result = problem.Solve(new[] { 2, 1, 1 });
            var expection = 3;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test3()
        {
            var result = problem.Solve(new[] { 1, 4, 2, 3 });
            var expection = 7;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test4()
        {
            var result = problem.Solve(new[] { 68, 75, 25, 50, 34, 29, 77, 1, 2, 69 });
            var expection = 304;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }
    }
}

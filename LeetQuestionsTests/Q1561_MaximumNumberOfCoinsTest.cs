using System;
using LeetQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetQuestionsTests
{
    [TestClass]
    public class Q1561_MaximumNumberOfCoinsTest
    {
        Q1561_MaximumNumberOfCoins problem = new Q1561_MaximumNumberOfCoins();

        [TestMethod]
        public void Test1()
        {
            var result = problem.Solve(new[] { 2, 4, 1, 2, 7, 8 });
            var expection = 9;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test2()
        {
            var result = problem.Solve(new[] { 2, 4, 5 });
            var expection = 4;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test3()
        {
            var result = problem.Solve(new[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 });
            var expection = 18;
            Console.WriteLine(result);
            Assert.AreEqual(result, expection);
        }
    }
}

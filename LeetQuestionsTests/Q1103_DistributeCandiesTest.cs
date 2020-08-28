using System;
using LeetQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetQuestionsTests
{
    [TestClass]
    public class Q1103_DistributeCandiesTest
    {
        Q1103_DistributeCandies problem = new Q1103_DistributeCandies();

        [TestMethod]
        public void Test1()
        {
            var result = problem.Solve(7, 4);
            var expection = new int[] { 1, 2, 3, 1 };
            Console.WriteLine(string.Join(",", result));
            CollectionAssert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test2()
        {
            var result = problem.Solve(10, 3);
            var expection = new int[] { 5, 2, 3 };
            Console.WriteLine(string.Join(",", result));
            CollectionAssert.AreEqual(result, expection);
        }
    }
}

using System;
using LeetQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetQuestionsTests
{
    [TestClass]
    public class Q1_TwoSumTest
    {
        Q1_TwoSum problem = new Q1_TwoSum();

        [TestMethod]
        public void Test1()
        {
            var result = problem.Solve(new int[] { 2, 7, 15, 11 }, 9);
            var expection = new int[] { 0, 1 };
            Console.WriteLine(string.Join(",", result));
            CollectionAssert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test2()
        {
            var result = problem.Solve(new int[] {3, 2, 4 }, 6);
            var expection = new int[] { 1, 2 };
            Console.WriteLine(string.Join(",", result));
            CollectionAssert.AreEqual(result, expection);
        }

        [TestMethod]
        public void Test3()
        {
            var result = problem.Solve(new int[] { 3, 3 }, 6);
            var expection = new int[] { 0, 1 };
            Console.WriteLine(string.Join(",", result));
            CollectionAssert.AreEqual(result, expection);
        }
    }
}

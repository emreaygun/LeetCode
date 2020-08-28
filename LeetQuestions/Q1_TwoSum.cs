using System.Collections.Generic;
using System.Linq;

namespace LeetQuestions
{
    public class Q1_TwoSum
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //Example:
        //Given nums = [2, 7, 11, 15], target = 9,
        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].


        public int[] Solve(int[] nums, int target)
        {
            var result = TwoSum(nums, target);
            return result;
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            var dictNum = new List<List<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                dictNum.Add(new List<int> { nums[i], i });
            }

            dictNum = dictNum.OrderBy(l => l[0]).ToList();

            int[] sonuc = null;

            var _first = 0;
            var _last = dictNum.Count - 1;

            for (; ; )
            {
                if (_first >= _last)
                    break;

                var _total = dictNum[_first][0] + dictNum[_last][0];

                if (_total < target)
                {
                    _first++;
                    continue;
                }
                else if (_total > target)
                {
                    _last--;
                    continue;
                }
                else
                {
                    sonuc = new int[] { dictNum[_first][1], dictNum[_last][1] };
                    break;
                }
            }

            return sonuc;
        }
    }
}

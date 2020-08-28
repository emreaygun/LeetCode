using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetQuestions
{
    public class Q1103_DistributeCandies
    {
        //We distribute some number of candies, to a row of n = num_people people in the following way:
        //We then give 1 candy to the first person, 2 candies to the second person, and so on until we give n candies to the last person.
        //Then, we go back to the start of the row, giving n + 1 candies to the first person, n + 2 candies to the second person, 
        //and so on until we give 2 * n candies to the last person.
        //This process repeats (with us giving one more candy each time, and moving to the start of the row after we reach the end) until we run out of candies.
        //The last person will receive all of our remaining candies (not necessarily one more than the previous gift).

        //Return an array(of length num_people and sum candies) that represents the final distribution of candies.

        //Example 1
        //Input: candies = 7, num_people = 4
        //Output: [1,2,3,1]
        //Explanation:
        //On the first turn, ans[0] += 1, and the array is [1,0,0,0].
        //On the second turn, ans[1] += 2, and the array is [1,2,0,0].
        //On the third turn, ans[2] += 3, and the array is [1,2,3,0].
        //On the fourth turn, ans[3] += 1 (because there is only one candy left), and the final array is [1,2,3,1].


        public int[] Solve(int candies, int num_people)
        {
            var result = DistributeCandies(candies, num_people);
            return result;
        }

        private static int[] DistributeCandies(int candies, int num_people)
        {
            int[] ans = new int[num_people];

            int rem_candies = candies;
            int normal_candy_part = 0;

            for (; ; )
            {
                if (rem_candies <= 0)
                    break;

                for (int people = 0; people < num_people; people++)
                {
                    normal_candy_part++;

                    var cur_candy_part = Math.Min(normal_candy_part, rem_candies);
                    ans[people] += cur_candy_part;

                    rem_candies -= cur_candy_part;
                }
            }

            return ans;
        }

        private static int[] DistributeCandies2ndMehod(int candies, int num_people)
        {
            int[] ans = new int[num_people];

            int num_full_turn = ((int) (candies * 2) / (num_people * (num_people + 1)));
            int num_add_turn = candies % (num_people * (num_people + 1) / 2) == 0 ? 0 : 1;

            var rem_candies = candies;

            for (int people = 0; people < num_people; people++)
            {
                ans[people] = (((num_full_turn - 1) * num_full_turn / 2) * num_people) + (num_full_turn * (people + 1));
                rem_candies -= ans[people];
            }

            if (num_add_turn > 0)
            {
                for (int people = 0; people < num_people; people++)
                {
                    ans[people] += Math.Min(((num_full_turn * num_people) + people), rem_candies);
                    rem_candies -= Math.Min(((num_full_turn * num_people) + people), rem_candies);
                }
            }

            return ans;
        }

    }
}

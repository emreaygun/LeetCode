using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetQuestions
{
    public class Q1563_StoneGame5
    {
        //There are several stones arranged in a row, and each stone has an associated value which is an integer given in the array stoneValue.

        //In each round of the game, Alice divides the row into two non-empty rows(i.e.left row and right row), 
        //then Bob calculates the value of each row which is the sum of the values of all the stones in this row.
        //Bob throws away the row which has the maximum value, and Alice's score increases by the value of the remaining row. 
        //If the value of the two rows are equal, Bob lets Alice decide which row will be thrown away. The next round starts with the remaining row.

        //The game ends when there is only one stone remaining.Alice's is initially zero.

        //Return the maximum score that Alice can obtain.

        //Example
        //Input: stoneValue = [6,2,3,4,5,5]
        //Output: 18
        //Explanation: In the first round, Alice divides the row to[6, 2, 3], [4, 5, 5]. The left row has the value 11 and the right row has value 14. 
        //Bob throws away the right row and Alice's score is now 11.
        //In the second round Alice divides the row to[6], [2,3]. This time Bob throws away the left row and Alice's score becomes 16 (11 + 5).


        public int Solve(int[] stoneValue)
        {
            var result = StoneGame5(stoneValue);
            return result;
        }

        private static int StoneGame5(int[] stoneValue)
        {
            var tmpStoneValue = ((int[]) stoneValue.Clone()).ToList();

            var totalScore = 0;
            while (tmpStoneValue.Count > 1)
            {
                tmpStoneValue = FindRemainigRow(tmpStoneValue);
                totalScore += tmpStoneValue.Sum();
            }

            return totalScore;
        }

        private static List<int> FindRemainigRow(List<int> stoneValue)
        {
            var stoneValueLeft = new List<int>();
            var stoneValueRight = stoneValue.Select(s => s).ToList();

            foreach (var stone in stoneValue)
            {
                var totalOfRowLeft = stoneValueLeft.Sum();
                var totalOfRowRight = stoneValueRight.Sum();

                var totalOfRowLeftNew = totalOfRowLeft + stone;
                var totalOfRowRightNew = totalOfRowRight - stone;

                if (Math.Abs(totalOfRowLeftNew - totalOfRowRightNew) > Math.Abs(totalOfRowLeft - totalOfRowRight))
                    break;

                stoneValueLeft.Add(stone);
                stoneValueRight.RemoveAt(0);
            }


            if (stoneValueLeft.Sum() > stoneValueRight.Sum())
                return stoneValueRight;

            if (stoneValueLeft.Sum() < stoneValueRight.Sum())
                return stoneValueLeft;


            var totalLeft = StoneGame5(stoneValueLeft.ToArray());
            var totalRight = StoneGame5(stoneValueRight.ToArray());

            return totalRight > totalLeft ? stoneValueRight : stoneValueLeft;
        }
    }
}

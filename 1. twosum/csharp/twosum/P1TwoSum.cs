//Problem:
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.
using System;

namespace P1TwoSum
{
    public class Solution
    {
        public int[] twoSum(int[] nums, int target) //Compare target subtract selected with current, return the index if true
        {
            int j = 1; //compare with next number
            for (int i = 0; i < nums.Length; i++)
            {
                for(int k = j; k < nums.Length; k++)
                {
                    if (nums[k] == target - nums[i])
                    {
                        int[] ans = { i, k };
                        return ans;
                    }
                }
                j++;
            }

            int[] anszero = { 0 };
            return anszero; //else return zero
        }
        static void Main(string[] args)
        {
            var sol = new Solution();
            int[] input = { 2, 7, 11, 15 }; //input numbers
            int inTarget = 9; //input target number
            foreach (var i in input)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            int[] ans = sol.twoSum(input, inTarget);
            
            //Print Results
            Console.Write("Result: ");
            foreach (var i in ans)
            {
                Console.Write("{0} ", i);
            }
            //Array.ForEach(ans, Console.Write); //Does not have space

        }
    }
}
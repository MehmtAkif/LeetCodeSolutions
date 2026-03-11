// ==============================
// #53 - Maximum Subarray
// Zorluk: Medium
// Konu: Array, Dynamic Programming
// Tarih: 11.03.2026
// ==============================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}

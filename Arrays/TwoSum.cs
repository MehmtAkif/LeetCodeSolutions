// ==============================
// #1 - Two Sum
// Zorluk: Easy
// Konu: Array, HashMap
// Tarih: 10.03.2026
// ==============================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { -1, -1 };
        }
    }
}
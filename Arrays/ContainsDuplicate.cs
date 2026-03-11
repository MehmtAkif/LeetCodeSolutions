// ==============================
// #217 - Contains Duplicate
// Zorluk: Easy
// Konu: Array, HashSet
// Tarih: 11.03.2026
// ==============================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateMethod(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                    return true;
                set.Add(num);
            }
            return false;
        }
    }
}

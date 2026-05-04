using Arrays;

namespace LeetCode.Tests
{
    public class TwoSumTests
    {
        private readonly TwoSum _twoSum = new TwoSum();

        [Fact]
        public void Test1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] result = _twoSum.Solve(nums, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 3, 2, 4 };
            int[] result = _twoSum.Solve(nums, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = { 3, 3 };
            int[] result = _twoSum.Solve(nums, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
}
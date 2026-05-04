using Arrays;

namespace LeetCode.Tests
{
    public class MaximumSubarrayTests
    {
        private readonly MaximumSubarray _maxSubarray = new MaximumSubarray();

        [Fact]
        public void Test1()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.Equal(6, _maxSubarray.MaxSubArray(nums));
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 1 };
            Assert.Equal(1, _maxSubarray.MaxSubArray(nums));
        }
    }
}
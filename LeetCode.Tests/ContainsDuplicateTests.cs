using Arrays;

namespace LeetCode.Tests
{
    public class ContainsDuplicateTests
    {
        private readonly ContainsDuplicate _duplicate = new ContainsDuplicate();

        [Fact]
        public void Test1()
        {
            int[] nums = { 1, 2, 3, 1 };
            Assert.True(_duplicate.ContainsDuplicateMethod(nums));
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 1, 2, 3, 4 };
            Assert.False(_duplicate.ContainsDuplicateMethod(nums));
        }
    }
}
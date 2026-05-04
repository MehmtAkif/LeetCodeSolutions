using Arrays;

namespace LeetCode.Tests
{
    public class ProductOfArrayExceptSelfTests
    {
        private readonly ProductOfArrayExceptSelf _product = new ProductOfArrayExceptSelf();

        [Fact]
        public void Test1()
        {
            int[] nums = { 1, 2, 3, 4 };
            Assert.Equal(new int[] { 24, 12, 8, 6 }, _product.ProductExceptSelf(nums));
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            Assert.Equal(new int[] { 0, 0, 9, 0, 0 }, _product.ProductExceptSelf(nums));
        }
    }
}
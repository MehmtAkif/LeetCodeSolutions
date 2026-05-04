using Arrays;

namespace LeetCode.Tests
{
    public class BestTimeToBuyAndSellStockTests
    {
        private readonly BestTimeToBuyAndSellStock _stock = new BestTimeToBuyAndSellStock();

        [Fact]
        public void Test1()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Assert.Equal(5, _stock.MaxProfit(prices));
        }

        [Fact]
        public void Test2()
        {
            int[] prices = { 7, 6, 4, 3, 1 };
            Assert.Equal(0, _stock.MaxProfit(prices));
        }
    }
}
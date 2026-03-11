using Arrays;


// Test 1
int[] prices1 = { 7, 1, 5, 3, 6, 4 };
BestTimeToBuyAndSellStock stock = new BestTimeToBuyAndSellStock();
Console.WriteLine($"Test 1: {stock.MaxProfit(prices1)}"); // Beklenen: 5

// Test 2
int[] prices2 = { 7, 6, 4, 3, 1 };
Console.WriteLine($"Test 2: {stock.MaxProfit(prices2)}"); // Beklenen: 0
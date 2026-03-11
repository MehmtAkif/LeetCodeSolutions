// Test 1
using Arrays;

int[] nums4 = { 1, 2, 3, 1 };
ContainsDuplicate duplicate = new ContainsDuplicate();
Console.WriteLine($"Test 1: {duplicate.ContainsDuplicateMethod(nums4)}"); // Beklenen: True

// Test 2
int[] nums5 = { 1, 2, 3, 4 };
Console.WriteLine($"Test 2: {duplicate.ContainsDuplicateMethod(nums5)}"); // Beklenen: False
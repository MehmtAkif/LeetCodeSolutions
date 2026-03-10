using Arrays;

// Test 1
int[] nums = { 2, 7, 11, 15 };
int target = 9;
TwoSum twoSum = new TwoSum();
int[] result = twoSum.Solve(nums, target);
Console.WriteLine($"Test 1 Output: [{result[0]}, {result[1]}]");

// Test 2
int[] nums2 = { 3, 4, 1, 1, 2 };
int target2 = 6;
int[] result2 = twoSum.Solve(nums2, target2);
Console.WriteLine($"Test 2 Output: [{result2[0]}, {result2[1]}]");

// Test 3
int[] nums3 = { 3, 3 };
int target3 = 6;
int[] result3 = twoSum.Solve(nums3, target3);
Console.WriteLine($"Test 3 Output: [{result3[0]}, {result3[1]}]");
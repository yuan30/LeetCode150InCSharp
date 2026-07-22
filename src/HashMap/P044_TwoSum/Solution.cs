public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"Input: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");

        nums = new int[] { 3, 2, 4 };
        target = 6;
        result = solution.TwoSum(nums, target);
        Console.WriteLine($"Input: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
    }
}
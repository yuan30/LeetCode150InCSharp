public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;

        for(int i=0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;

        int k = solution.RemoveElement(nums, val);

        Console.WriteLine("New length: " + k);
        Console.WriteLine("Modified array: " + string.Join(", ", nums.Take(k)));
    }
}
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] left = new int[nums.Length];
        int right = 1;
        left[0] = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            left[i] = left[i-1]*nums[i-1];
        }
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            left[i] *= right;
            right = right * nums[i];
        }
        return left;
    }
}

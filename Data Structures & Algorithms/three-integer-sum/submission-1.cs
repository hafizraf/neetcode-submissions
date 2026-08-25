public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        int left = 0;
        Array.Sort(nums);
        while(left < nums.Length - 1)
        {
            int mid = left+1;
            int right = nums.Length - 1;
            while(mid < right)
            {
                int sum = nums[left] + nums[mid] + nums[right];
                if(sum == 0)
                {
                    res.Add(new List<int>{nums[left],nums[mid],nums[right]});
                    mid++;
                    while(mid < nums.Length - 1 && nums[mid] == nums[mid - 1])
                    {
                        mid++;
                    }
                    right--;
                    while(right > 0 && nums[right] == nums[right+1])
                    {
                        right--;
                    }
                }
                else if(sum < 0)
                {
                    mid++;
                }
                else
                {
                    right--;
                }
            }
            left++;
            while(left < nums.Length - 1 && nums[left] == nums[left - 1])
            {
                left++;
            }
        }
        return res;
    }
}

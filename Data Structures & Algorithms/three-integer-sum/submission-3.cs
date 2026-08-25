public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);
        for(int left = 0; left < nums.Length - 2; left++)
        {
            if(left > 0 && nums[left] == nums[left - 1])
            {
                continue;
            }
            int mid = left+1;
            int right = nums.Length - 1;
            while(mid < right)
            {
                int sum = nums[left] + nums[mid] + nums[right];
                if(sum == 0)
                {
                    res.Add(new List<int>{nums[left],nums[mid],nums[right]});
                    while(mid < right && nums[mid] == nums[mid + 1])
                    {
                        mid++;
                    }
                    while(right > mid && nums[right] == nums[right-1])
                    {
                        right--;
                    }
                    mid++;
                    right--;
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
        }
        return res;
    }
}

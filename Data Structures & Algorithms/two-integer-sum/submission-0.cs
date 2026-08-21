public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>(nums.Length);
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.TryGetValue(target - nums[i], out int index))
            {
                return new int[] {index, i};
            }
            dict[nums[i]] = i;
        }
        return null;
    }
}

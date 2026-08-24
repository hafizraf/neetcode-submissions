public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];
        Dictionary<int,int> counts = new Dictionary<int,int>(nums.Length);
        foreach(int num in nums)
        {
            counts[num] = counts.GetValueOrDefault(num) + 1;
        }
        List<int>[] buckets = new List<int>[nums.Length  + 1];
        foreach(var (num, frequency) in counts)
        {
            if(buckets[frequency] == null)
            {
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(num);
        }
        int index = 0;
        for(int i = nums.Length; i >= 1; i--)
        {
            if(buckets[i] == null)
            {
                continue;
            }
            foreach(int j in buckets[i])
            {
                res[index++] = j;
            }
            if(index == k)
            {
                break;
            }
        }
        return res;
    }
}

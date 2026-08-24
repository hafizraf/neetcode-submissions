public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];
        Dictionary<int,int> counts = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            counts[num] = counts.GetValueOrDefault(num) + 1;
        }
        int i = 0;
        foreach(var pair in counts.OrderByDescending(x => x.Value))
        {
            if(i == k)
            {
                break;
            }
            res[i++] = pair.Key;
        }
        return res;
    }
}

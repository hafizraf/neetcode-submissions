public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        int max = 0;
        foreach(int n in nums)
        {
            hash.Add(n);
        }
        foreach(int n in nums)
        {
            if(hash.Contains(n - 1))
            {
                continue;
            }
            int current = n;
            int length = 1;
            while(hash.Contains(++current))
            {
                 length++;
            }
            max = Math.Max(length, max);
        } 
        return max;
    }
}

public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>(nums);
        int max = 0;
        foreach(int n in hash)
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

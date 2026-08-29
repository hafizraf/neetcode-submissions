public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0)
        {
            return 0;
        }
        HashSet<char> hash = new HashSet<char>();
        int left = 0;
        int max = 1;
        hash.Add(s[0]);
        for(int i = 1; i < s.Length; i++)
        {
            while(hash.Contains(s[i]))
            {
                hash.Remove(s[left]);
                left++;
            }
            hash.Add(s[i]);
            max = Math.Max(i - left + 1, max);
        }
        return max;
    }
}

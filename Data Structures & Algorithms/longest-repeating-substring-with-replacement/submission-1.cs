public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        int left = 0;
        int right = 0;
        int max = 0;
        while(right < s.Length)
        {
            freq[s[right]] = freq.GetValueOrDefault(s[right]) + 1;
            if(freq[s[right]] > max)
            {
                max = freq[s[right]];
            }
            while(right - left + 1 - max > k)
            {
                freq[s[left]]--;
                left++;
            }
            right++;
        }
        return Math.Min(max+k, s.Length);
    }
}

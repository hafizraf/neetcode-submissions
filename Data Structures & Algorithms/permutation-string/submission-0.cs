public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
        {
            return false;
        }
        int[] counts = new int[26];
        int[] counts2 = new int[26];
        for(int i = 0; i < 26; i++)
        {
            counts[i] = 0;
            counts2[i] = 0;
        }
        foreach(char c in s1)
        {
            counts[c- 'a']++;
        }
        int left = 0;
        for(int i = 0; i < s1.Length - 1; i++)
        {
            counts2[s2[i] - 'a']++;
        }
        while(left + s1.Length <= s2.Length)
        {
            counts2[s2[left + s1.Length - 1] - 'a']++;
            for(int i = 0; i < 26; i++)
            {
                if(counts[i] != counts2[i])
                {
                    break;
                }
                if(i == 25)
                {
                    return true;
                }
            }
            counts2[s2[left] - 'a']--;
            left++;
        }
        return false;
    }
}

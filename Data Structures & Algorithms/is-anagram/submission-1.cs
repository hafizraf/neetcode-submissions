public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char,int> sCounts = new Dictionary<char,int>(s.Length);
        foreach(char c in s)
        {
            sCounts[c] = sCounts.GetValueOrDefault(c) + 1;
        }
        foreach(char c in t)
        {
            if(!sCounts.TryGetValue(c, out int count))
            {
                return false;
            }
            sCounts[c] = count - 1;
            if(sCounts[c] < 0)
            {
                return false;
            }
        }
        return true;
    }
}

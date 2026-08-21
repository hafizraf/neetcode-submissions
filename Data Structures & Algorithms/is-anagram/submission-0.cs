public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char,int> sCounts = new Dictionary<char,int>(s.Length);
        Dictionary<char,int> tCounts = new Dictionary<char,int>(s.Length);
        for(int i = 0; i < s.Length; i++)
        {
            if(sCounts.TryGetValue(s[i], out int sCount))
            {
                sCounts[s[i]] = sCount + 1;
            }
            else
            {
                sCounts[s[i]] = 1;
            }
            if(tCounts.TryGetValue(t[i], out int tCount))
            {
                tCounts[t[i]] = tCount + 1;
            }
            else
            {
                tCounts[t[i]] = 1;
            }
        }
        foreach(var key in sCounts.Keys)
        {
            if(!tCounts.TryGetValue(key, out int count) || count != sCounts[key])
            {
                return false;
            }            
        }
        return true;
    }
}

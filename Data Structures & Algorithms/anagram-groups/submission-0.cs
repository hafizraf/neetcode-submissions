public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>(strs.Length);
        foreach(string s in strs)
        {
            int[] arr = new int[26];
            foreach(char c in s)
            {
                arr[c - 'a']++;
            }
            string key = string.Join("#", arr);
            if(dict.TryGetValue(key, out List<string> value))
            {
                value.Add(s);
            }
            else
            {
                dict[key] = new List<string>{s};
            }
        }
        List<List<string>> groups = new List<List<string>>();
        foreach(var value in dict.Values)
        {
            groups.Add(value);
        }
        return groups;
    }
}

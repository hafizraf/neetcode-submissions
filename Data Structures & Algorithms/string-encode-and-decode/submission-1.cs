public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        foreach(string s in strs)
        {
            encoded += s.Length.ToString() + "#" + s;
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        for(int i = 0; i < s.Length; )
        {
            int count = 0;
            while(s[i] != '#')
            {
                count = count * 10 + (s[i++] - '0');
            }
            res.Add(s.Substring(++i, count));
            i+= count;
        }
        return res;
   }
}

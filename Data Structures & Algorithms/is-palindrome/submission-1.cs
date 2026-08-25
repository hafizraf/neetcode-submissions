public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        s = s.ToLower();
        while(right > left)
        {
            while(left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while(right > left && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            if(right>left)
            {
                if(s[left] != s[right])
                {
                    return false;
                }
            }
            left++;
            right--;
        }
        return true;
    }
}

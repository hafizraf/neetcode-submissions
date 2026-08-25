public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
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
                if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))                
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

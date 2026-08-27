public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int max = 0;
        while(right>left)
        {
            int area;
            if(heights[right] < heights[left])
            {
                area = heights[right] * (right - left);
                right--;
            }
            else
            {
                area = heights[left] * (right - left);
                left++;
            }
            if(area>max)
            {
                max = area;
            }
        }
        return max;
    }
}

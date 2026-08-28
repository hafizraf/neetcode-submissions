public class Solution {
    public int Trap(int[] height) {
        int total = 0;
        int[] leftMax = new int[height.Length];
        int max = 0;
        for(int i = 0; i < height.Length; i++)
        {
            if(height[i] > max)
            {
                max= height[i];
            }
            leftMax[i] = max;
        }
        max = 0;
        for(int i = height.Length - 1; i >= 0; i--)
        {
            if(height[i] > max)
            {
                max= height[i];
            }
            total += Math.Min(leftMax[i],max) - height[i];
        }
        return total;
    }
}

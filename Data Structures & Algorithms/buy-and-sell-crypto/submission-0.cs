public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int max = 0;
        for(int i = 1; i <prices.Length; i++)
        {
            if(prices[i] < buy)
            {
                buy = prices[i];
            }
            else
            {
                max = Math.Max((prices[i] - buy), max);
            }
        }
        return max;
    }
}

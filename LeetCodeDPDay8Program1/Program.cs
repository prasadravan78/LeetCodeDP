namespace LeetCodeDPDay8Program1
{
    internal class BuySellStockWithCooldown
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[] { 1,2,4 }));
            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            int len = prices.Length;

            if (len < 2)
            {
                return 0;
            }
            
            int[] sell = new int[len];
            int[] buy = new int[len];

            buy[0] = -prices[0];
            buy[1] = -Math.Min(prices[0], prices[1]);
            sell[1] = Math.Max(0, buy[0] + prices[1]);

            for (int i = 2; i < len; i++)
            {
                buy[i] = Math.Max(buy[i - 1], sell[i - 2] - prices[i]);
                sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i]);
            }

            return sell[len - 1];
        }
    }
}
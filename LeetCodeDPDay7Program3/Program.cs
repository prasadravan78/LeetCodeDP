namespace LeetCodeDPDay7Program3
{
    internal class BuySellStock2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[] { 5, 4, 3, 2, 1 }));
            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            int buyPrice = prices[0];
            int profit = 0;
            int sellPrice = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > buyPrice)
                {
                    sellPrice = prices[i];
                }
                else if (buyPrice > prices[i])
                {
                    buyPrice = prices[i];
                    sellPrice = 0;
                }

                if (sellPrice > 0 && sellPrice - buyPrice > 0)
                {
                    profit += sellPrice - buyPrice;
                    sellPrice = 0;
                    buyPrice = prices[i];
                }
            }

            return profit;
        }
    }
}
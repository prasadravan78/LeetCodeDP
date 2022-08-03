namespace LeetCodeDPDay2Program2
{
    internal class MinimumClimbingStairsCost
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
            Console.ReadLine();
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 2)
            {
                return Math.Min(cost[0], cost[1]);
            }

            for (int i = cost.Length - 3; i >= 0; i--)
            {
                cost[i] += Math.Min(cost[i + 1], cost[i + 2]);
            }

            return Math.Min(cost[0], cost[1]);
        }
    }
}
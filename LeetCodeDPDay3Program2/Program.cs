namespace LeetCodeDPDay3Program2
{
    internal class HouseRobberCircular
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rob(new int[] { 1, 2, 3 }));
            Console.ReadLine();
        }

        public static int Rob(int[] nums)
        {
            int len = nums.Length;

            if (len == 0)
            {
                return 0;
            }

            if (len == 1)
            {
                return nums[0];
            }

            return Math.Max(Rob(nums, 0, len - 2), Rob(nums, 1, len - 1));
        }

        private static int Rob(int[] arr, int left, int right)
        {
            if (left == right)
            {
                return arr[left];
            }

            int[] dp = new int[arr.Length];
            dp[left] = arr[left];
            dp[left + 1] = Math.Max(arr[left], arr[left + 1]);

            for (int i = left + 2; i <= right; i++)
            {
                dp[i] = Math.Max(arr[i] + dp[i - 2], dp[i - 1]);
            }

            return dp[right];
        }
    }
}
namespace LeetCodeDPDay5Program1
{
    internal class MaximumSumSubArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubArray(new int[] { 5, 4, -100, 7, 8 }));
            Console.ReadLine();
        }

        public static int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int currentMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentMax = Math.Max(currentMax + nums[i], nums[i]);
                max = Math.Max(max , currentMax);
            }

            return max;
        }
    }
}
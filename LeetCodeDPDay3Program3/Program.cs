namespace LeetCodeDPDay3Program3
{
    internal class DeleteAndEarnProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeleteAndEarn(new int[] { 2, 2, 3, 3, 3, 4 }));
            Console.ReadLine();
        }

        public static int DeleteAndEarn(int[] nums)
        {
            int numsMax = nums.Max();

            int[] sum = new int[numsMax + 1];

            foreach (var num in nums)
            {
                sum[num] += num;
            }

            for (int i = 2; i < sum.Length; i++)
            {
                sum[i] = Math.Max(sum[i - 1], sum[i - 2] + sum[i]);
            }

            return sum[numsMax];
        }
    }
}
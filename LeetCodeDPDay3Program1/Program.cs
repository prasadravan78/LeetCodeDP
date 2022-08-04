namespace LeetCodeDPDay3Program1
{
    internal class HouseRobber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rob(new int[] { 2, 7, 9, 3, 1 }));
            Console.ReadLine();
        }

        public static int Rob(int[] nums)
        {
            var prev = 0;
            var next = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = prev;
                prev = Math.Max(nums[i] + next, prev);
                next = temp;
            }

            return prev;
        }
    }
}
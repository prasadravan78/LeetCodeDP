namespace LeetCodeDPDay4Program1
{
    internal class JumpGame
    {
        static void Main(string[] args)
        {
            if (CanJump(new int[] { 3, 2, 1, 0, 4 }))
            {
                Console.WriteLine("Can Jump");
            }

            Console.ReadLine();
        }

        public static bool CanJump(int[] nums)
        {
            int nearest = nums.Length - 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= nearest)
                {
                    nearest = i;
                }
            }

            return nearest == 0;
        }
    }
}
namespace LeetCodeDPDay4Program2
{
    internal class JumpGame2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Jump(new int[] { 4, 3, 1, 1, 4,3 }));
            Console.ReadLine();
        }

        public static int Jump(int[] nums)
        {
            int count = 0;  
            int max = 0;
            int current = 0;

            for (int i = 0; i < nums.Length-1; i++)
            { 
                max = Math.Max(max, i+nums[i]);

                if (i == current)
                {
                    count++;
                    current = max;
                }
            }

            return count;
        }
    }
}
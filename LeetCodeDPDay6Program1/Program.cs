namespace LeetCodeDPDay6Program1
{
    internal class MaximumProductInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProduct(new int[] { 0, 2 }));
            Console.ReadLine();
        }

        public static int MaxProduct(int[] nums)
        {
            int max = nums[0];
            int head = 1;
            int tail = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                head = (head == 0 ? 1 : head) * nums[i];
                tail = (tail == 0 ? 1 : tail) * nums[nums.Length - 1 - i];

                max = Math.Max(max, Math.Max(head, tail));
            }

            return Math.Max(max, Math.Max(head, tail));
        }
    }
}
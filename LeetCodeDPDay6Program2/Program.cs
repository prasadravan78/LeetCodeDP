namespace LeetCodeDPDay6Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxLen(new int[] { 4, 5, -2, -11 }));
            Console.ReadLine();
        }

        public static int GetMaxLen(int[] nums)
        {
            int positive = 0;
            int negative = 0;
            int max = 0;

            foreach (var num in nums)
            {
                if (num == 0)
                {
                    positive = 0;
                    negative = 0;
                }
                else if (num > 0)
                {
                    positive += 1;
                    negative = negative == 0 ? 0 : negative + 1;
                }
                else
                {
                    var temp = positive;
                    positive = negative == 0 ? 0 : negative + 1;
                    negative = temp + 1;
                }

                max = Math.Max(max, positive);
            }

            return max;
        }
    }
}
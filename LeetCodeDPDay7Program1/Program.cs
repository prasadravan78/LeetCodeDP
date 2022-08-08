namespace LeetCodeDPDay7Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxScoreSightseeingPair(new int[] { 1,3,5 }));
            Console.ReadLine();
        }

        public static int MaxScoreSightseeingPair(int[] values)
        {
            int max = 0;
            int currentMax = 0;

            for (int i = 0; i < values.Length; ++i)
            {
                max = Math.Max(max, currentMax + values[i] - i);
                currentMax = Math.Max(currentMax, values[i] + i);
            }

            return max;
        }
    }
}
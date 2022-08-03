namespace LeetCodeDPDay2Program1
{
    internal class ClimbingStairs
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(44));
            Console.ReadLine();
        }

        public static int ClimbStairs(int n)
        {
            var twoSteps = 2;
            var oneStep = 1;
            var i = 3;
            var requiredSteps = 0;

            if (n == 1)
            {
                return oneStep;
            }
            else if (n == 2)
            {
                return twoSteps;
            }

            while (i <= n)
            {
                requiredSteps = twoSteps + oneStep;
                oneStep = twoSteps;
                twoSteps = requiredSteps;
                i++;
            }

            return requiredSteps;
        }
    }
}
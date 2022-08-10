namespace LeetCodeDPDay9Program2
{
    internal class TrappingRainWater
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Trap(new int[] { 1, 0, 3, 0, 2 }));
            Console.ReadLine();
        }

        public static int Trap(int[] height)
        {
            var totalWater = 0;
            var left = 0;
            var right = height.Length - 1;
            var maxLeft = 0;
            var maxRight = 0;

            if (height == null || height.Length < 1)
            {
                return totalWater;
            }

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= maxLeft)
                    {
                        maxLeft = height[left];
                    }
                    else
                    {
                        totalWater += maxLeft - height[left];
                    }

                    left++;
                }
                else
                {
                    if (height[right] >= maxRight)
                    {
                        maxRight = height[right];
                    }
                    else
                    {
                        totalWater += maxRight - height[right];
                    }

                    right--;
                }
            }

            return totalWater;
        }
    }
}
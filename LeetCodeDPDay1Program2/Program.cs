namespace LeetCodeDPDay1Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tribonacci(5));
            Console.ReadLine();
        }

        public static int Tribonacci(int n)
        {
            int[] array = { 0, 1, 1 };

            for(int i=3;i<=n;i++)
            {
                array[i % 3] = array[0] + array[1] + array[2];
            }

            return array[n%3];
        }
    }
}
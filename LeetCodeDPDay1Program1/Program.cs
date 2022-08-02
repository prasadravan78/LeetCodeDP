namespace LeetCodeDPDay1Program1
{
    internal class FibonacciNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(32));
            Console.ReadLine();
        }

        public static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
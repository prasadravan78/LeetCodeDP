using System.Runtime.Intrinsics.Arm;

namespace LeetCodeDPDay9Program1
{
    internal class WordBreakProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordBreak("applepenapple", new List<string>() { "apple", "pen" }));
            Console.ReadLine();
        }

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            var isValidDictionary = new bool[s.Length + 1];
            isValidDictionary[0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (isValidDictionary[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        isValidDictionary[i] = true;
                        break;
                    }
                }
            }

            return isValidDictionary[s.Length];
        }
    }
}
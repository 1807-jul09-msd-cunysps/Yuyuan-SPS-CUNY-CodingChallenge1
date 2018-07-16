using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testCases = new string[3];
            testCases[0] = "A nut for a jar of tuna.";
            testCases[1] = "Borrow or rob";
            testCases[2] = "343";
            foreach (string s in testCases)
            {
                Console.WriteLine(IsPalindrome(s));
            }
        }

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = Regex.Replace(s, @"[^a-z]+", "");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(s[s.Length - i - 1]))
                    continue;
                return false;
            }
            return true;
        }
    }
}

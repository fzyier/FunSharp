using System;
using System.Collections.Generic;

namespace FunSharp
{
    class Program
    {
        public static bool Scramble(string str1, string str2)
        {
            List<char> list = new List<char>(str2);
            foreach (char c in str1)
            {
                list.Remove(c);
            }

            if (list.Count == 0)
                return true;
            else
                return false;
        }
        static void Main()
        {
            Console.WriteLine(Scramble("rkqodlw", "world"));
            Console.WriteLine(Scramble("cedewaraaossoqqyt", "codewars"));
            Console.WriteLine(Scramble("katas", "steak"));
        }
    }
}
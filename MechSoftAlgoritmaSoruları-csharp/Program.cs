using System;
using System.Collections.Generic;

namespace MechSoftAlgoritmaSoruları_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }
        public static string fixText(string s)
        {
            string[] newS = s.Split(' ');

            string ret = "";
            char[] reversedText;
            for (int i = 0; i < newS.Length; i++)
            {
                if (newS[i].Contains('(') && newS[i].Contains(')'))
                {
                    newS[i] = newS[i].Substring(1, newS[i].Length - 2);
                }
                else
                {
                    reversedText = newS[i].ToCharArray();
                    Array.Reverse(reversedText);
                    newS[i] = new string(reversedText);
                }
                ret += newS[i] + " ";
            }
            return ret;
        }
        public static int findMax(string t, string z)
        {
            List<string> subs = new List<string>();

            string[] splits;
            int maxValue = 0, length = 0, word = 0, subLen = t.Length;
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 1; j < subLen + 1; j++)
                {
                    subs.Add(t.Substring(i, j));
                }
                subLen--;
            }
            for (int k = 0; k < subs.Count; k++)
            {
                splits = z.Split(subs[k]);
                length = splits.Length - 1;
                word = subs[k].Length;

                if (length * word > maxValue)
                {
                    maxValue = length * word;
                }
            }

            return maxValue;
        }
    }
}


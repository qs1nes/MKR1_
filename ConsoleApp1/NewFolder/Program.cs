using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var input = File.ReadAllLines("INPUT.TXT");
        int K = int.Parse(input[0]);
        string s = input[1];

        string result = GetLexicographicallyMinimalString(s, K);

        File.WriteAllText("OUTPUT.TXT", result);
    }

    public static string GetLexicographicallyMinimalString(string s, int K)
    {
        int n = s.Length;
        var result = new List<char>();
        var minHeap = new SortedSet<(char ch, int index)>();
        int start = 0;

        for (int i = 0; i < n; i++)
        {
            minHeap.Add((s[i], i));

            if (minHeap.Count > K + 1)
            {
                minHeap.Remove((s[start], start));
                start++;
            }

            if (i >= K)
            {
                var minChar = minHeap.Min;
                result.Add(minChar.ch);
                minHeap.Remove(minChar);
            }
        }

        return new string(result.ToArray());
    }
}

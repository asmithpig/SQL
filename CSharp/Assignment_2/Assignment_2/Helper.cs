using System.Text.RegularExpressions;

namespace Assignment_2;

public static class Helper
{
    public static void ManageElements()
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string? operation = Console.ReadLine();
            if (string.IsNullOrEmpty(operation))
            {
                continue;
            }
            switch (operation.Substring(0, 2))
            {
                case "+ ": 
                    list.Add(operation.Substring(2));
                    break;
                case "- ":
                    list.Remove(operation.Substring(2));
                    break;
                case "--":
                    list.Clear();
                    break;
            }
            Console.WriteLine("List:");
            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
        }
    }

    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        Console.WriteLine($"prime numbers in [{startNum}, {endNum}]");
        bool[] prime = new bool[endNum + 1];    // 0 for prime, 1 not prime
        for (int i = 2; i * i <= endNum; i++)
        {
            if (!prime[i])
            {
                for (int j = i * i; j <= endNum; j += i)
                {
                    prime[j] = true;
                }
            }
        }
        List<int> ret = new List<int>();
        for (int i = Math.Max(2, startNum); i <= endNum; i++)
        {
            if (!prime[i])
            {
                ret.Add(i);
            }
        }
        return ret.ToArray();
    }

    public static int[] RotateSum()
    {
        Console.WriteLine("RotateSum: input n integers (space separated on a single line) and an integer k");
        string? arrString = Console.ReadLine();
        string? kString = Console.ReadLine();

        if (string.IsNullOrEmpty(arrString) || string.IsNullOrEmpty(kString))
        {
            return Array.Empty<int>();
        }
        
        int k = int.Parse(kString);
        string[] splits = new Regex("\\s+").Split(arrString);
        int[] arr = new int[splits.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(splits[i]);
        }
        
        int[] ret = new int[arr.Length];
        for (int j = 1; j <= k; j++)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                ret[(i + j) % arr.Length] += arr[i];
            }
        }
        return ret;
    }

    public static int[] FindLongestEqualSequence(int[] arr)
    {
        int maxLen = 1;
        int currLen = 1;
        int maxInt = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currLen++;
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxInt = arr[i];
                }
            }
            else
            {
                currLen = 1;
            }
        }

        return Enumerable.Repeat(maxInt, maxLen).ToArray();
    }

    public static void FindMostFrequentNumber(int[] arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int maxFreq = 1;
        int maxNum = arr[0];
        foreach (int i in arr)
        {
            freq.Add(i, freq.GetValueOrDefault(i, 0) + 1);
            if (freq[i] > maxFreq)
            {
                maxFreq = freq[i];
                maxNum = i;
            }
        }
        List<int> modes = new List<int>();
        foreach (int i in arr)
        {
            if (freq[i] == maxFreq)
            {
                modes.Add(i);
            }
        }

        if (modes.Count == 1)
        {
            Console.WriteLine($"The number {maxNum} is the most frequent (occurs {maxFreq} times)");
        }
        else
        {
            Console.WriteLine($"The numbers {string.Join(", ", modes)} have the same maximal frequency (each occurs {maxFreq} times). The leftmost of them is {modes.First()}.");
        }
    }
}
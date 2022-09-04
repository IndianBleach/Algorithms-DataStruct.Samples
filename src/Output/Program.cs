using Structs;

internal class Program
{
    private static void Main(string[] args)
    {
        int FibonacciCycle(int n)
        {
            int prev = 0;
            int cur = 1;

            for (int i = 2; i <= n; i++)
            {
                int tmp = cur;
                cur += prev;
                prev = tmp;
            }

            return cur;
        }

        int FibonacciRecursive(int n)
        {
            if (n == 0) return n;
            if (n == 1) return n;

            return FibonacciRecursive(n - 2) + FibonacciRecursive(n - 1);
        }

        bool IsPriveNumber(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        int LinearSearch(int key, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                    return i;
            }
            return -1;
        }

        int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            return arr;
        }

        //https://proglib.io/p/6-search-algorithms-java
        int[] GetPatternStringArray(string pattern)
        {
            int len = pattern.Length;
            int[] res = new int[len];
            int i = 1;
            int cur = 0;

            res[0] = 0;

            while (cur < len)
            {
                if (pattern[i] == pattern[cur])
                {
                    cur++;
                    i++;
                    res[i] = cur;
                }
                else
                {
                    if (cur != 0)
                        cur = res[cur - 1];
                    else
                    {
                        i++;
                        res[i] = cur;
                    }
                }
            }
            return res;
        }

        List<int> PerformKMPStringPatternSearch(string searchText, string pattern)
        {
            int[] patternArray = GetPatternStringArray(pattern);

            int textIndex = 0;
            int patternIndex = 0;

            List<int> founds = new();

            while (textIndex < searchText.Length)
            {
                if (pattern[patternIndex] == searchText[textIndex])
                {
                    patternIndex++;
                    textIndex++;
                }

                if (patternIndex == pattern.Length)
                {
                    founds.Add(textIndex - patternIndex);
                    patternIndex = patternArray[patternIndex - 1];
                }
                else if (textIndex < searchText.Length && pattern[patternIndex] != searchText[textIndex])
                {
                    if (patternIndex != 0)
                    {
                        patternIndex = patternArray[patternIndex - 1];
                    }
                    else
                    {
                        textIndex++;
                    }
                }
            }

            return founds;
        }

        int[] res = BubbleSort(new int[] { 1, 7, 2, 59, 24, 56 });

        // Linked List

        Structs.LinkedList<int> list = new();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        list.Remove(3);

        Console.WriteLine(list.Contains(3));
        Console.WriteLine(list.Contains(5));


    }
}
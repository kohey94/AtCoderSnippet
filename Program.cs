using System;

namespace AtCoderSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var arr = new int[N];
            for (long x = 1; x <= 100; x++)
            {
                for (long y = 1; y <= 100; y++)
                {
                    for (long z = 1; z <= 100; z++)
                    {
                        long num = (x * x) + (y * y) + (z * z) + (x * y) + (y * z) + (z * x);
                        if (num <= N) arr[num - 1] += 1;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

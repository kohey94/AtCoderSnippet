using System;

namespace AtCoderSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var arr = new int[N];
            Func3(N, arr);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
                
            }
        }

        static int Func2(int x, int y, int z)
        {
            var q1 = x * x;
            var q2 = y * y;
            var q3 = z * z;
            var q4 = x * y;
            var q5 = y * z;
            var q6 = z * x;
            return q1 + q2 + q3 + q4 + q5 + q6;
        }

        static void Func3(int N, int[] arr)
        {
            for (int x = 1; x <= N / 6; x++)
            {
                for (int y = 1; y <= N / 6; y++)
                {
                    for (int z = 1; z <= N / 6; z++)
                    {
                        if ((x+y+z) >= N) break;
                        var num = Func2(x, y, z);
                        if (num < N) arr[num - 1] += 1;
                    }
                }
            }
        }
    }
}

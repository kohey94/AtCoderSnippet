using System;

namespace AtCoderSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(" ");
            long x = 0;

            for (int i = 0; i < N - 1; i++)
            {
                var ax = long.Parse(A[i]);
                var ay = long.Parse(A[i + 1]);
                if (ax > ay)
                {
                    var z = ax - ay;
                    A[i + 1] = (ay + z).ToString();
                    x += z;
                }
            }
            Console.WriteLine(x);
        }
    }
}
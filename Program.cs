using System;

namespace AtCoderSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            var N_X = Console.ReadLine().Split(" ");

            var N = uint.Parse(N_X[0].ToString());
            var X = uint.Parse(N_X[1].ToString());
            decimal a = 0;
            
            for (int i = 0; i < N; i++)
            {
                var V_P = Console.ReadLine().Split(" ");
                var V = decimal.Parse(V_P[0].ToString());
                var P = decimal.Parse(V_P[1].ToString());

                a += (V * P / 100);
                if (a > X)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
            if (a <= X) Console.WriteLine(-1);
        }
    }
}
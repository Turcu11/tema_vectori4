using System;

namespace vectori_4_
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] fibo = fiibonacci(5);
            Console.WriteLine(fibo[0]);
            for (int i = 0; i < fibo.Length; i++)
            {
                if (fibo[i] != 0)
                    Console.WriteLine(fibo[i]);
            }
        }


        static int[] fiibonacci(int n)
        {
            int[] fi = new int[100];
            fi[0] = 0;
            if (n == 0) return fi;
            fi[1] = 1;
            if (n == 1) return fi;
            int i = 1;

            while (fi[i] < n)
            {
                i++;
                fi[i] = fi[i - 1] + fi[i - 2];

            }
            return fi;
        }
    }
}
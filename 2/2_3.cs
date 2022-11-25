using System;


namespace Homework2_3
{
    class Program
    {
        public static void dz()
        {
            int[] a = new int[3];
            for (int i = 2; i >= 0; i--)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            long n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    n = n << 1;
                    if ((a[i] & (1 << 15)) == 1 << 15)
                    {
                        n = n + 1;
                    }
                    a[i] = a[i] << 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
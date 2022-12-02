using System;
using System.Linq;

namespace Homework1_3
{
    class Program
    { 
        public static void dz()
        {
            int[,] tochki = new int[3, 2];int[] n = new int[2];int[] maxx = {0, 0}; int a, b, c;
            for (int i = 0; i < 3; i++)
            {
                n = Console.ReadLine().Split().Select(chislo => Convert.ToInt32(chislo)).ToArray();
                tochki[i, 0] = n[0];
                tochki[i, 1] = n[1];
                if (n[0] > maxx[0])
                {
                    maxx[0] = n[0];
                }
                if (n[1] > maxx[1])
                {
                    maxx[1] = n[1];
                }
            }
            for (int i = 0; i <= maxx[1]; i++)
            {
                for (int j = 0; j <= maxx[0]; j++)
                {
                    a = ((tochki[0, 0] - j) * (tochki[1, 1] - tochki[0, 1]) - (tochki[1, 0] - tochki[0, 0]) * (tochki[0, 1] - i));
                    b = ((tochki[1, 0] - j) * (tochki[2, 1] - tochki[1, 1]) - (tochki[2, 0] - tochki[1, 0]) * (tochki[1, 1] - i));
                    c = ((tochki[2, 0] - j) * (tochki[0, 1] - tochki[2, 1]) - (tochki[0, 0] - tochki[2, 0]) * (tochki[2, 1] - i));
                    if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }
                Console.Write("\n");
            }   
        }
    } 
}

using System;


namespace Homework2_1
{
    class Program
    {
        static int To2(int n)
        {
            if (n == 0){
                return n;
            }
            return To2(n >> 1) * 10 + (n & 1);
        }
        public static void dz()
        {
           int n = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(To2(n));
        }
    }   
}
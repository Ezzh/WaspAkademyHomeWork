using System;


namespace Homework2_2
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
        static void dop0andto2(int n)
        {
            int ln = 0; int a = n;
            while (a > 0) {
                ln =  ln + 1;
                a = a >> 1;
            }
            for (; ln < 8; ln++){
                Console.Write("0");
            }
            Console.WriteLine(To2(n));
        }
        public static void dz()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            dop0andto2(a);
            dop0andto2(b);
            Console.WriteLine("--------");
            dop0andto2(a + b);
        }
    }   
}



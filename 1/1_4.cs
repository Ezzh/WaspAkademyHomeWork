using System;


namespace Homework1_4
{
    class Program
    { 
        static int Factorial(int n){
            if (n == 1 || n == 0){
                return 1;
            }
            return n * Factorial(n - 1);
        }
        public static void dz()
        {
           int height = Convert.ToInt32(Console.ReadLine()); int n;
           Console.WriteLine("1");
           for (int i = 1; i <= height; i++){
            for (int j = 0; j <= i; j++){
                n = Factorial(i) / (Factorial(j) * Factorial(i - j));
                Console.Write($"{n} ");
            }
            Console.Write("\n");
           }
        }   
    }
} 


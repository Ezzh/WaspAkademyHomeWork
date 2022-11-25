using System;


namespace Homework1_2{
    class Program{ 
        public static void dz()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    if (i == j){
                        Console.Write(n + " ");
                    }
                    if (i > j){
                        Console.Write(n - (i - j) + " ");
                    }
                    if (i < j){
                        Console.Write(n - (j - i) + " ");
                    }
                }
                Console.Write("\n");
                
            }
        } 
    }
}
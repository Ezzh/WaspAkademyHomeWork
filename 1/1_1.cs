using System;


namespace Homework1_1{
    class Program{
        
        public static void dz(){
            int u = 6;
            Console.WriteLine($"Start {u}");
            for (int i = 3; i <= 9; i++)
            {
                for (int j = i - 1; j >= 2; j--)
                {
                    for (int g = j - 1; g >= 1; g--)
                    {
                        for (int f = g - 1; f >= 0; f--)
                        {
                            Console.WriteLine($"{i}{j}{g}{f}");
                        }
                    }
                }
            }
        } 
    }
}
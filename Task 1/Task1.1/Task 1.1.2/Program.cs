using System;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N = ");

            Int32.TryParse(Console.ReadLine(), out int N);

            if (!SuitableParametr(N))
            {
                new Exception("Значение меньше 0");
                Console.WriteLine("Значение меньше 0");
            }
           

            for (int i = 0; i <= N; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static bool SuitableParametr(int number) => number >= 0;

        
    }
}

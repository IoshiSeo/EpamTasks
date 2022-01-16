using System;

namespace Task_1._1._3
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

            int spaces, stars;

            for (int i = 1; i < N * 2; i += 2) 
            {

                spaces = N - i / 2;
                stars = i;

                while (spaces > 0) 
                {
                    Console.Write(" ");
                    spaces--;
                }

                while (stars > 0) 
                {
                    Console.Write("*");
                    stars--;

                   
                }
                Console.WriteLine();
            }
        }

        static bool SuitableParametr(int number) => number >= 0;
    }
}

using System;

namespace Task_1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTree();
        }

        static void DrawTree() 
        {
            int N = WriteInt();

            for (int i = 0; i <= N; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    string branch = new String('*', j);
                    Console.WriteLine(branch.PadLeft(N) + "*" + branch);
                }

            }

        }
        static int WriteInt() 
        {
            Console.Write("Введите число N большее 0 = ");

            Int32.TryParse(Console.ReadLine(), out int N);

            if (!SuitableParametr(N))
            {
                new Exception("Значение меньше 0");
                Console.WriteLine("Значение меньше 0");
            }

            return N;
        }

        static bool SuitableParametr(int number) => number >= 0;
    }
}

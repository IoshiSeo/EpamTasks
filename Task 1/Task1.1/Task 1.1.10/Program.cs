using System;

namespace Task_1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = CreateRandomArray();

            Console.Write("Массив: ");
            PrintArray(array);

            Console.WriteLine($"Сумма элементов, сумма номеров которых чётна : {GetSum(array)}");

        }

        static int GetSum(int[,] arr) 
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ( (i + j) % 2 == 0) sum += arr[i, j];

                }
            }

            return sum;
        }
        static int[,] CreateRandomArray()
        {
            Random r = new Random();
            var arr = new int[4, 4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    arr[i, j] = r.Next(100);
                    
                }
            }

            return arr;
        }

        static void PrintArray(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + " ");

                }

                Console.WriteLine();
            }

           
        }
    }
}

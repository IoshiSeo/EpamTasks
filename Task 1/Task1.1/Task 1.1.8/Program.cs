using System;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = CreateRandomArray();

            Console.Write("Массив: ");
            SeeArray(arr);

            Console.WriteLine("\n\n");

            arr = ReplacePositives(arr);

            Console.Write("Измененный массив: ");
            SeeArray(arr);

            Console.WriteLine("\n\n");
        }
        static int[,,] CreateRandomArray()
        {
            Random r = new Random();
            var arr = new int[4, 4, 4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = r.Next(-100, 100);
                    }
                }
            }

            return arr;
        }
        static int[,,] ReplacePositives(int[,,] arr)
        {
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if(arr[i, j, k] > 0) arr[i, j, k] = 0;
                    }
                }
            }

            return arr;
        }
        static void SeeArray(int[,,] arr)
        {

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }

}

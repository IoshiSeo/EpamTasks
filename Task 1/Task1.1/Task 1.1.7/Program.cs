using System;

namespace Task_1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = CreateArray();
            var sortedArray = SortArray(array);


            Console.Write("Отсортированный массив: ");
            SeeArray(sortedArray);

        }

        
        static int[] CreateArray()
        {
            int N = WriteInt();

            Random randomazer = new Random();
            var arr = new int[N];

            int min = 1000;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomazer.Next(1000);

                if (arr[i] > max) max = arr[i];
                if (min > arr[i]) min = arr[i];
            }

            Console.Write("Массив: ");
            SeeArray(arr);

            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент в массиве: {min}");
            Console.WriteLine($"Максимальный элемент в массиве: {max}");

            return arr;
        }

        static void SeeArray(int[] arr)
        {

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static int[] SortArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        static int WriteInt()
        {
            Console.Write("Введите число элементов в массиве большее 0 = ");

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

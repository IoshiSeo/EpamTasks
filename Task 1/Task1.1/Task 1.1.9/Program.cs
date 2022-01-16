using System;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = CreateArray();
            Console.WriteLine($"Сумма неотрицательных элементов: {PositiveSum(array)}");
        }

        static int[] CreateArray()
        {
            int N = WriteInt();

            Random randomazer = new Random();
            var arr = new int[N];


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomazer.Next(-100, 100);

            }

            Console.Write("Массив: ");
            SeeArray(arr);

            return arr;
        }

        static int PositiveSum(int[] arr) 
        {
            int sum = 0;

            foreach (var i in arr)
            {
                if (i >= 0)
                    sum += i;
            }

            return sum;
        }

        static void SeeArray(int[] arr)
        {

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
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

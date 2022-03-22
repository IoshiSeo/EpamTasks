using System;

namespace Task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 4, 3, 2, 1, 1, 4 };

            Console.Write("Массив: ");

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Сумма всех элементов: {arr.FindSum()}");
            Console.WriteLine($"Среднее значение: {arr.FindAverage()}");
            Console.WriteLine($"Самый часто повторяющийся элемент: {arr.FindOftenRepeatedElement()}");

            arr = arr.ApplyToMass((x) => x + x);

            Console.WriteLine();
            Console.Write("Изменённый массив: ");

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}

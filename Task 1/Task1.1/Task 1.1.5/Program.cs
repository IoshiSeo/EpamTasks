using System;

namespace Task_1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i < 1000; i++)
            {

                if (i % 3 == 0 || i % 5 == 0) Sum += i;

            }
            Console.WriteLine($"Сумма чисел от 1 до 1000, кратных 3 или 5 равна {Sum}");
        }


    }
}

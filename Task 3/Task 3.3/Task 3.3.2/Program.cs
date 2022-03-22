using System;

namespace Task_3._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово или строчку: ");
            string str = Console.ReadLine();

            Console.WriteLine("Слово на языке: " + str.GetLanguage());
        }
    }
}

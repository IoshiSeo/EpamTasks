using System;

namespace Task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            var inputText = Console.ReadLine();
            Analysis analysis = new Analysis(inputText);

            Console.WriteLine(analysis.AnalyzeMaxWord());
            Console.ReadLine();


        }
    }
}

using System;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            

            Console.WriteLine($"Средняя длина слов: {AverageWordLength(input)}"); // Округлил до 1 знака после запятой
        }

        static double AverageWordLength(string input) 
        {
            input.Trim();

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double quantityLetter = 0;

            foreach (string word in words)
            {
               
                foreach (char i in word)
                {
                    if (Char.IsLetterOrDigit(i)) quantityLetter++;
                }
            }
 
            double AverageWordLength = Math.Round( quantityLetter / (double)words.Length, 1) ;

            
            return AverageWordLength;
        }

    }
}

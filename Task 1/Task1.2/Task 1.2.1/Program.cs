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
            double quantityWords = 0;

            foreach (string word in words)
            {
                bool flag = false;

                foreach (char i in word)
                {
                    if (Char.IsLetterOrDigit(i))
                    {
                        quantityLetter++;
                        flag = true;
                    } 
                }

                if (flag)
                {
                    quantityWords++;
                }
            }
 
            double AverageWordLength = Math.Round( quantityLetter / quantityWords, 1) ;

            
            return AverageWordLength;
        }

    }
}

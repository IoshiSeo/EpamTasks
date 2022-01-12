using System;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            Console.Write($"Количество слов, начинающихся с маленькой буквы: {CountLowerCaseWords(input)}"); // Вариант со *
        }

        static int CountLowerCaseWords(string input)
        {
            int CountLowerCaseWords = 0;
            char[] separators = { '.', ',', ';', ':', ' '};


            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in words)
            {
                if (isLowerCaseWord(i))
                {
                    CountLowerCaseWords++;
                }
            }


            return CountLowerCaseWords;
        }

        static bool isLowerCaseWord(string input) => input[0].ToString() == input[0].ToString().ToLower(); 
    }
}

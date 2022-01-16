using System;
using System.Text;

namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Результат: {Validate(input)}");
        }

        static string Validate(string input)
        {
            char[] separators = { '.', '?', '!'};
            string[] sentences = input.Split(separators);

            StringBuilder resultString = new StringBuilder();


            for(int i = 0; i < sentences.Length - 1; i++) 
            {
                
                var arr = sentences[i].Trim().ToCharArray();

                arr[0] = Char.ToUpper(arr[0]);

                if (i != 0) resultString.Append(' ');

                resultString.Append(arr);
                resultString.Append('.');

                
            }


            return resultString.ToString();
        }
    }
}

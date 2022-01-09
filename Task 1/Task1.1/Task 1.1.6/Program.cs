using System;
using System.Collections.Generic;

namespace Task_1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var styles = new List<string>();

            while (true)
            {
                Console.WriteLine($"Параметры надписи: {GetStyles(styles)}");
                Console.WriteLine("Введите: ");
                Console.WriteLine("       1: bold");
                Console.WriteLine("       2: italic");
                Console.WriteLine("       3: underline");
                Console.WriteLine("Напишите 4, чтобы выйти");

                int input = WriteInt();


                if (styles.Contains(ChooseStyle(input)))
                {
                    styles.Remove(ChooseStyle(input));
                }    
                else styles.Add(ChooseStyle(input));

                
                if (input == 4) break;
            }
        }

        static string GetStyles( List<string> styles) => styles.Count == 0 ? "None" : string.Join(" ", styles.ToArray());
        
        static string ChooseStyle(int style) => style switch
        {
            1 => "bold",
            2 => "italic",
            3 => "underline",
            _ => null
        };

        static int WriteInt()
        {
            
            Int32.TryParse(Console.ReadLine(), out int N);

            if (!SuitableParametr(N))
            {
                Console.WriteLine("Такого параметра не существует");
                Console.WriteLine("Выберите заново");
                WriteInt();
            }

            return N;
        }

        static bool SuitableParametr(int number) => number >= 1 && number <= 4;
    }
}

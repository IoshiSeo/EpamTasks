using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    class Analysis
    {

        public string inputText { get; init; }
        Dictionary<string, int> words = new Dictionary<string, int>();
        private string maxWord = "";

        public Analysis(string input)
        {
            inputText = input.Trim();
            try
            {
                ValidateText(inputText);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ValidateText(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                throw new ArgumentException("Строка не может быть пустой.");
            }

        }

        public string AnalyzeMaxWord()
        {
            var array = inputText.ToCharArray();

            string word = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLetterOrDigit(array[i]))
                {
                    word += array[i].ToString();
                }
                else if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                    word = "";
                }
                else
                {
                    words[word]++;
                    word = "";
                }

                if (i == array.Length - 1)
                {
                    if (!words.ContainsKey(word))
                    {
                        words.Add(word, 1);
                        word = "";
                    }
                    else
                    {
                        words[word]++;
                        word = "";
                    }
                }

            }
            int max = FindMaxWord();
            if (max <= 1)
            {
                return "Оригинальный текст";
            }
            else
            {
                return $"Не оригинальный текст. Слово {maxWord} было использовано {max} раза";

            }

        }
        private int FindMaxWord()
        {
            int max = 1;

            foreach (var item in words)
            {
                if (item.Value > max)
                {
                    max = item.Value;

                    maxWord = item.Key;
                }
            }

            return max;
        }
    }
}

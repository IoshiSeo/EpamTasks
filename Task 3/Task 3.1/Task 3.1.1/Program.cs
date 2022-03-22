using System;
using System.Collections.Generic;

namespace Task3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = ReadIntInput();

            Console.Write("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            int removalStep = ReadIntInput();

            var list = new List<int>(N);

            for (int i = 0; i < N; i++)
            {
                list.Add(i + 1);
            }

            bool flag = true;
            int step = 1;
            int roundNumber = 1;

            while (flag)
            {
                for (int i = 0; i < list.Count; i++, step++)
                {
                    if (step == removalStep)
                    {
                        Console.WriteLine($"Раунд {roundNumber}. {list[i]} человек был вычеркнут. Людей осталось: {list.Count - 1}.");
                        list.RemoveAt(i);
                        step = 1;
                    }
                    if (list.Count < removalStep)
                    {
                        flag = false;
                        break;
                    }
                }
                roundNumber++;
            }

            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");

        }



        static int ReadIntInput()
        {
            string input;
            int res;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out res) && res > 0);
            return res;
        }
    }
}

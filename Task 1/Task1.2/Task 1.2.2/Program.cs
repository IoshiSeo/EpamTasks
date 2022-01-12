using System;
using System.Linq;
using System.Text;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string inputString = Console.ReadLine();

            Console.Write("Введите строку для удвоения: ");
            string doublerString = Console.ReadLine();

            Console.WriteLine($"Вывод: {Doubler(inputString, doublerString)}");
        }


        static string Doubler(string inputString, string doublerString)
        {
            StringBuilder resultString = new StringBuilder(inputString);
            


            foreach (char i in doublerString.Distinct()) 
            {
                if (inputString.Contains(i)) 
                {
                    resultString = resultString.Replace(i.ToString(), i.ToString() + i.ToString());
                }
            
   
            }
            
            return resultString.ToString();
        }
    }


}

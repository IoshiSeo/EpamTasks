using System;

namespace Task1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;


            Console.Write("Введите длину прямоугольника: ");  
            Int32.TryParse(Console.ReadLine(), out a);

            Console.Write("Введите ширину прямоугольника: ");
            Int32.TryParse(Console.ReadLine(), out b);


            try
            {
                Rectangle entity = new Rectangle(a, b);
                Console.Write($"Площадь прямоугольника = {entity.square}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


    }



}

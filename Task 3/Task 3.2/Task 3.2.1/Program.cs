using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new DynamicArray<int>(5);

            array.AddRange(new List<int>(){1,2,3,3} );
            array.Add(4);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            array.Remove(3);
            array[2] = 19;
            array.Insert(5, 3);

            Console.WriteLine();

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}

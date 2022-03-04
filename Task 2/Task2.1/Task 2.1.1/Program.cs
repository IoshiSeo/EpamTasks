using System;

namespace Task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myString = new char[] { 'M', 'y', ' ', 'S', 't', 'r', 'i', 'n', 'g', ' ', 'i', 's'};

            MyString string1 = new MyString(myString);
            MyString string2 = " very big";

            MyString concatString = new MyString(string1.ConcatStrings(string2));

            Console.WriteLine(concatString.ToString());

            Console.WriteLine(concatString.FindSymbolIndex('M'));

            Console.WriteLine(concatString[6]);

        }
    }
}

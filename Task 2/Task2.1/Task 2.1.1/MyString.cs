using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    class MyString
    {
        private char[] _charsArray;
        public int Length 
        {
            get => _charsArray.Length;
        }

        public MyString(char[] charsArray)
        {
            _charsArray = charsArray;
        }

        public MyString(string str) : this(str.ToCharArray())
        {
            
        }

        public static implicit operator MyString(string v) => new MyString(v);

        public int FindSymbolIndex(char value)
        {
            if (_charsArray.Length == 0)
            {
                return -1;
            }
                

            for (int i = 0; i < _charsArray.Length; i++)
            {
                if (_charsArray[i] == value)
                {
                    return i;
                }
                    
            }

            return -1;
        }

        public char[] ConcatStrings(char value)
        {
            var result = new char[_charsArray.Length + 1];

            _charsArray.CopyTo(result, 0);
            result[result.Length - 1] = value;


            return result;
        }
        public char[] ConcatStrings(MyString secondString)
        {
            var result = new char[_charsArray.Length + secondString._charsArray.Length];
            _charsArray.CopyTo(result, 0);


            secondString._charsArray.CopyTo(result, _charsArray.Length);

            return result;

        }

        public bool IsEqual(char[] firstString, char[] secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
                

            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    return false;
                }
                    
            }


            return true;
        }

        public char[] ToCharArray()
        {
            var copy = new char[_charsArray.Length];
            _charsArray.CopyTo(copy, 0);

            return copy;
        }

        public override string ToString() => new string(_charsArray);

        public char this[int index]
        {
            get => _charsArray[index];
            private set => _charsArray[index] = value;
        }

        public static int ConvertToInt(MyString convertString) => Convert.ToInt32(convertString.ToString());

        public static double ConvertToDouble(MyString convertString) => Convert.ToDouble(convertString.ToString());

        
    }
}

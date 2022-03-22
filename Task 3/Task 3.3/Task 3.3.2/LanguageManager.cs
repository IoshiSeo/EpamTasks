using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._2
{
    public static class LanguageManager
    {
        public static string GetLanguage(this string inputString)
        {
            inputString = inputString.ToLower().Trim();


            bool english = false;
            bool russian = false;
            bool number = false;

            foreach (var item in inputString)
            {
                if (item >= 'а' && item <= 'я')
                {
                    russian = true;
                }

                if (item >= 'a' && item <= 'z')
                {
                    english = true;
                }

                if (item >= '0' && item <= '9')
                {
                    number = true;
                }

                if (item.ToString() == " ")
                { 
                    return "Mixed";
                }
                    
            }

            switch (english, russian, number)
            {
                
                case (false, true, false):
                    return "Russian";
                case (true, false, false):
                    return "English";
                case (false, false, true):
                    return "Numbers";
                default:
                    return "Mixed";
            }
        }
    }
}

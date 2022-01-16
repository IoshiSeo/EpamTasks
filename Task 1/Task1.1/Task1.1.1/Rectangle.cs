using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._1
{
    class Rectangle
    {
        private int a;

        private int b;
       

        public Rectangle(int a, int b)
        {
            if (suitableParametr(a))
            {
                this.a = a;
            }
            else
            {
                throw new ArgumentException("Значение параметра меньше 0");
            }


            if (suitableParametr(b))
            {
                this.b = b;
            }
            else
            {
                throw new ArgumentException("Значение параметра меньше 0");
            }
        }

        private bool suitableParametr(int number) => number >= 0;
     
        public int square => a * b;
    }
}

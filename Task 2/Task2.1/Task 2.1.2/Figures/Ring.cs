using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Ring:FigureWithArea
    {
        private Circle innerCircle;
        private Circle outerCircle;


        public Ring(Circle innerCircle, Circle outerCircle)
        {
            if (innerCircle.Radius > outerCircle.Radius)
            {
                throw new Exception("Внутренний радиус должен быть меньше внешнего");
            }
                
            this.innerCircle = innerCircle;
            this.outerCircle = outerCircle;
        }
        public override double GetArea() => Math.PI *
                (outerCircle.Radius * outerCircle.Radius - innerCircle.Radius * innerCircle.Radius);


        public override double GetPerimeter()
        {
            double ringLength = outerCircle.GetPerimeter() + innerCircle.GetPerimeter();
            return ringLength;
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, $"Координаты центров: {innerCircle.Center}" +
                $"Сумма длин окружностей: {GetPerimeter()}" +
                $"Площадь кольца: {GetArea()}");
        }

    }
}

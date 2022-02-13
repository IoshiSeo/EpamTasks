using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Circle:FigureWithArea
    {

        public Point Center { get; }
        public double Radius { get; }

        public Circle(Point center, double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть меньше или равен 0");
            }
                
            Center = center;
            Radius = radius;
        }

        public Circle(double x, double y, double r) : this(new Point(x, y), r) 
        { 

        }

        public override double GetArea() => 2 * Math.PI * (Radius * Radius);

        public override double GetPerimeter() => 2 * Math.PI * Radius;

        public override string ToString()
        {
            return string.Join(Environment.NewLine, "Круг: ", $"Координаты центра {Center}",
                $"Длина окружности: {GetPerimeter()}",
                $"Радиус {Radius}", $"Площадь: {GetArea()}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Triangle:FigureWithArea
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public double lineA { get; }
        public double lineB { get; }
        public double lineC { get; }
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;

            lineA = new Line(a, b).Length;
            lineB = new Line(b, c).Length;
            lineC = new Line(c, a).Length;
        }
        public override double GetPerimeter() => lineA + lineB + lineC;

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - lineA) * (p - lineB) * (p - lineC));
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, "Треугольник: ", $"Координаты вершин треугольника: {A}{B}{C}", base.ToString());
        }


    }
}

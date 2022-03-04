using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Rectangle : Square
    {
        public double Width { get; private set; }
        public Rectangle(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {

        }
        protected override void Validate()
        {
            Length = new Line(A, B).Length;
            Width = new Line(B, C).Length;


            if (Length != new Line(C, D).Length || Width != new Line(A, D).Length)
            {
                throw new Exception("Противоположеные стороны прямоугольника не равны");
            }
                

            if (Math.Abs((C.CoordinateX - B.CoordinateX) * (A.CoordinateX - B.CoordinateX) +
                (C.CoordinateY - B.CoordinateY) * (A.CoordinateY - B.CoordinateY)) > Math.E &&
                Math.Abs((C.CoordinateX - D.CoordinateX) * (A.CoordinateX - D.CoordinateX)) +
                (C.CoordinateY - D.CoordinateY) * (A.CoordinateY - D.CoordinateY) > Math.E)
            {
                throw new Exception("Углы прямоугольника должны быть прямыми");
            }
                
        }

        public override double GetArea() => Width * Length;

        public override double GetPerimeter() => 2 * (Length + Width);

        public override string ToString() => string.Join("", "Прямоугольник: ", base.ToString().Replace("Квадрат:", ""));
    }
}

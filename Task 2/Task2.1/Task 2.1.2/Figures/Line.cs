using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Line:Figure
    {
        private Point startPoint;
        private Point endPoint;
        private double length;

        public Line(Point start, Point end)
        {
            ValidateSide(start, end);

            startPoint = start;
            endPoint = end;

            SetLength(start, end);
        }

        public double[] StartCoordinates
        {
            get => new double[2] { startPoint.CoordinateX, startPoint.CoordinateY };
        }

        public double[] EndCoordinates
        {
            get => new double[2] { endPoint.CoordinateX, endPoint.CoordinateY };
        }

        private void SetLength(Point start, Point end) =>
            length = Math.Sqrt(Math.Pow((end.CoordinateX - start.CoordinateX), 2) +
                      Math.Pow((end.CoordinateY - start.CoordinateY), 2));

        public double Length
        {
            get => length;
        }
        private void ValidateSide(Point startPoint, Point endPoint)
        {
            if (startPoint.CoordinateX == endPoint.CoordinateX && startPoint.CoordinateY == endPoint.CoordinateY)
            {

                throw new Exception("Координаты точек начала и конца линии не могут быть равны");
            }

        }
        public override string ToString()
        {
            return $"{{ {startPoint} }},{{ {endPoint} }}";
        }
        
    }
}

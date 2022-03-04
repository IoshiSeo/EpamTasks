using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2
{
    class Repository
    {
        protected List<Figure> figures = new List<Figure>();

        public void AddFigure(Figure figure) => figures.Add(figure);
        public List<Figure> GetAllFigures()
        {
            var copy = new List<Figure>(figures);
            return copy;
        }


        public void Clear() => figures.Clear();
    }
}

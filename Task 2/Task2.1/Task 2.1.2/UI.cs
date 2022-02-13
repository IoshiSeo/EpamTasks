using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2
{
    class UI:Repository
    {
        public UI() 
        {
            Menu();
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1: Добавить фигуру");
                Console.WriteLine("2: Вывести все фигуры");
                Console.WriteLine("3: Очистить");
                Console.WriteLine("4: Выход");
                var input = ReadIntInput();

                if (input == 4)
                {
                    break;
                }
                    
                HandleInput(input);
            }
        }
        public void HandleInput(int input)
        {
            switch (input)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Print();
                    break;
                case 3:
                    Clear();
                    break;
            }
        }

        private void Add()
        {
            Console.WriteLine("Какую фигуру вы хотите добавить?");
            Console.WriteLine("1: Круг");
            Console.WriteLine("2: Кольцо");
            Console.WriteLine("3: Квадрат");
            Console.WriteLine("4: Прямоугольник");
            Console.WriteLine("5: Треугольник");
            Console.WriteLine("6: Вернуться назад");

            CreateFigure(ReadIntInput());
        }
        private void CreateFigure(int input)
        {
            switch (input)
            {
                case 1:
                    CreateCircle();
                    break;
                case 2:
                    CreateRing();
                    break;
                case 3:
                    CreateSquare();
                    break;
                case 4:
                    CreateRectangle();
                    break;
                case 5:
                    CreateTriangle();
                    break;
                case 6:
                    break;

            }
        }
        private void Print()
        {
            foreach (var figure in GetAllFigures())
            {
                Console.WriteLine(figure);
            }
                
        }

        private int ReadIntInput()
        {
            string input;
            int res;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out res));
            return res;
        }

        private void CreateCircle()
        {
            double x = inputCenter('x');
            double y = inputCenter('y');
            Console.Write("Введите радиус: ");
            double r = ReadDoubleInput();
            try
            {
                figures.Add(new Circle(x, y, r));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Фигура не была создана");
            }
        }
        private void CreateRing()
        {
            double x = inputCenter('x');
            double y = inputCenter('y');
            Console.Write("Введите внешний радиус кольца: ");
            double outer = ReadDoubleInput();
            Console.Write("Введите внутренний радиус: ");
            double inner = ReadDoubleInput();
            try
            {
                figures.Add(new Ring(new Circle(x, y, inner), new Circle(x, y, outer)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Фигура не была создана");
            }
        }
        private void CreateSquare()
        {
            double xA = inputCorner('A', 'x');
            double yA = inputCorner('A', 'y');
            double xB = inputCorner('B', 'x');
            double yB = inputCorner('B', 'y');
            double xC = inputCorner('C', 'x');
            double yC = inputCorner('C', 'y');
            double xD = inputCorner('D', 'x');
            double yD = inputCorner('D', 'y');

            try
            {
                figures.Add(new Square(new Point(xA, yA), new Point(xB, yB), new Point(xC, yC), new Point(xD, yD)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
        private void CreateRectangle()
        {
            double xA = inputCorner('A', 'x');
            double yA = inputCorner('A', 'y');
            double xB = inputCorner('B', 'x');
            double yB = inputCorner('B', 'y');
            double xC = inputCorner('C', 'x');
            double yC = inputCorner('C', 'y');
            double xD = inputCorner('D', 'x');
            double yD = inputCorner('D', 'y');

            try
            {
                figures.Add(new Rectangle(new Point(xA, yA), new Point(xB, yB), new Point(xC, yC), new Point(xD, yD)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Фигура не была создана");
            }
            
        }
        private void CreateTriangle()
        {
            double xA = inputCorner('A', 'x');
            double yA = inputCorner('A', 'y');
            double xB = inputCorner('B', 'x');
            double yB = inputCorner('B', 'y');
            double xC = inputCorner('C', 'x');
            double yC = inputCorner('C', 'y');
            try
            {
                figures.Add(new Triangle(new Point(xA, yA), new Point(xB, yB), new Point(xC, yC)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Фигура не была создана");
            }

        }
        private double inputCenter(char c)
        {
            Console.Write($"Введите координату центра {c}: ");
            var res = ReadDoubleInput();
            Console.WriteLine();
            return res;
        }
        private double inputCorner(char C, char c)
        {
            Console.Write($"Введите координаты угла {C}:\n {c}:");
            var res = ReadDoubleInput();
            Console.WriteLine();
            return res;
        }
        private double ReadDoubleInput()
        {
            string input;
            double res;
            do
            {
                input = Console.ReadLine();
            } while (!double.TryParse(input, out res));
            return res;
        }


    }

    
}

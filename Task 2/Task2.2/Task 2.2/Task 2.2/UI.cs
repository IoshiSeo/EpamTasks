using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Field;

namespace Task_2._2._1
{
    class UI
    {
        public UI()
        {
            Menu();
        }
        public void Menu()
        {
           
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1: Новая игра");
            Console.WriteLine("2: Выбрать уровень");
            Console.WriteLine("3: Настройки");
            Console.WriteLine("4: Выход");

            var input = ReadIntInput();

            

            HandleInput(input);
            
        }

        public void HandleInput(int input) 
        {
            switch (input) 
            {
                case 1:
                    GameField level = new GameField();
                    break;
                case 2:
                    GameField selectedLevel = new GameField(ChoiseLevel());


                    break;
                case 3:
                    break;
            
            }
        
        
        }

        private StatusGameLevel ChoiseLevel() 
        {
            Console.WriteLine("Напишите уровень, в который вы бы хотели сыграть:");
            var input = ReadIntInput();

            switch (input) 
            {
                case 1:
                    return StatusGameLevel.level_1;
                case 2:
                    return StatusGameLevel.level_2;
                case 3:
                    return StatusGameLevel.level_3;
                case 4:
                    return StatusGameLevel.level_4;
                default:
                    return StatusGameLevel.level_1;
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

    }
}

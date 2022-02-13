using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Characters;
using Task_2._2._1.Characters.Enemies;
using Task_2._2._1.Bonuses;
namespace Task_2._2._1.Field
{
    enum StatusGameLevel
    {
        level_1,
        level_2,
        level_3,
        level_4
    }
    

    class GameField
    {
        public StatusGameLevel statusGame;
        public Repository levelRepository;

        public int Width { get; init; }
        public int Height { get; init; }

        public GameField():this(StatusGameLevel.level_1)
        {
            
          
        }

        public GameField(StatusGameLevel statusGame) 
        {
            this.statusGame = statusGame;

            Width = 100;
            Height = 100;

            switch (statusGame)
            {

                case StatusGameLevel.level_1:
                    levelRepository = new Repository(StatusGameLevel.level_1);
                    break;
                case StatusGameLevel.level_2:
                    levelRepository = new Repository(StatusGameLevel.level_2);
                    break;
                case StatusGameLevel.level_3:
                    levelRepository = new Repository(StatusGameLevel.level_3);
                    break;
                case StatusGameLevel.level_4:
                    levelRepository = new Repository(StatusGameLevel.level_4);
                    break;

            }
        }


        EnemySpawner spawner = new EnemySpawner();
        
    }
}

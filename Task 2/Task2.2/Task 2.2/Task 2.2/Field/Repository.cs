using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Characters.Enemies;
using Task_2._2._1.Field.Objects;

namespace Task_2._2._1.Field
{
    class Repository
    {
        protected List<MyObject> objects = new List<MyObject>();

        protected List<Enemy> enemies = new List<Enemy>();

        public Repository(StatusGameLevel statusGame) 
        {
            switch (statusGame)
            {

                case StatusGameLevel.level_1:
                    LoadingEntitiesLevel1();
                    break;
                case StatusGameLevel.level_2:
                    LoadingEntitiesLevel2();
                    break;
                case StatusGameLevel.level_3:
                    LoadingEntitiesLevel3();
                    break;
                case StatusGameLevel.level_4:
                    LoadingEntitiesLevel4();
                    break;

            }

        }



        public void AddObject(MyObject _object) => objects.Add(_object);
        public void AddEnemy(Enemy _enemy) => enemies.Add(_enemy);
        public List<MyObject> GetAllObjects()
        {
            var copy = new List<MyObject>(objects);
            return copy;
        }

        public List<Enemy> GetAllEnemies()
        {
            var _enemies = new List<Enemy>(enemies);
            return _enemies;
        }
        public void Clear()
        {
            
            objects.Clear();
            enemies.Clear();
        }

        public void LoadingEntitiesLevel1() 
        {
            this.AddObject(new Pit());
            this.AddObject(new Pit());
            this.AddObject(new Shrub());

            this.AddEnemy(new EvilCopybara());
            this.AddEnemy(new Bunny());
        }

        public void LoadingEntitiesLevel2()
        {
            this.AddObject(new Honey());
            this.AddObject(new Pit());
            this.AddObject(new Shrub());

            this.AddEnemy(new Bunny());
            this.AddEnemy(new Robot());
        }

        public void LoadingEntitiesLevel3()
        {
            this.AddObject(new Pit());
            this.AddObject(new Pit());
            this.AddObject(new Shrub());

            this.AddEnemy(new EvilCopybara());
            this.AddEnemy(new EvilCopybara());
            this.AddEnemy(new EvilCopybara());
        }

        public void LoadingEntitiesLevel4()
        {
            this.AddObject(new Pit());
            this.AddObject(new Pit());
            this.AddObject(new Shrub());

            this.AddEnemy(new Bunny());
            this.AddEnemy(new Bunny());

            foreach(MyObject f in objects)
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}

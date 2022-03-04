using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Field;

namespace Task_2._2._1.Characters
{
    public class Player : Character
    {
        protected override int Health { get; set; }
        protected override int Damage { get; set; }
        protected override int Speed { get; set; }
        protected override double AttackSpeed { get; set; }
        protected override Coordinates Coordinates { get; set; }
        

        public Player() 
        {
            setParametersDefault();
        }

        protected override void setParametersDefault() 
        {
            Health = 100;
            Damage = 20;
            Speed = 10;
            AttackSpeed = 1.0;
            Coordinates = new Coordinates(10, 20);
        }

        protected override void Attack()
        {
            throw new NotImplementedException();
        }

        protected override void Move()
        {
            throw new NotImplementedException();
        }

        protected override void TakeDamage()
        {
            throw new NotImplementedException();
        }
        
    }
}

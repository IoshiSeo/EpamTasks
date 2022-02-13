using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Field;

namespace Task_2._2._1.Characters.Enemies
{
    public class Robot : Enemy
    {
        protected override int Health { get; set; }
        protected override int Damage { get; set; }
        protected override int Speed { get; set; }
        protected override double AttackSpeed { get; set; }
        protected override Coordinates Coordinates { get; set; }

        public Robot()
        {
            setParametersDefault();
        }

        protected override void setParametersDefault()
        {
            Health = 200;
            Damage = 10;
            Speed = 5;
            AttackSpeed = 1;
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

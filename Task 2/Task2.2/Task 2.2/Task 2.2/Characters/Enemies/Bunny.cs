﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Field;

namespace Task_2._2._1.Characters.Enemies
{
    public class Bunny : Enemy
    {
        protected override int Health { get; set; }
        protected override int Damage { get; set; }
        protected override int Speed { get; set; }
        protected override double AttackSpeed { get; set; }
        protected override Coordinates Coordinates { get; set; }

        public Bunny() 
        {
            setParametersDefault();
        }

        protected override void setParametersDefault()
        {
            Health = 30;
            Damage = 5;
            Speed = 15;
            AttackSpeed = 2.0;
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

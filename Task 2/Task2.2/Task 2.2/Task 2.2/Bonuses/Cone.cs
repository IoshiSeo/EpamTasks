﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Bonuses
{
    public class Cone : DamageUpBonus
    {
       
        public Cone() 
        {
            valueBonus = 5;
        }
        protected override void UpDamage()
        {
            throw new NotImplementedException();
        }
    }
}

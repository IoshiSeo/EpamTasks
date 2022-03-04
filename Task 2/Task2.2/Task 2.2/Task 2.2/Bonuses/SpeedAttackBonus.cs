using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Bonuses
{
    public abstract class SpeedAttackBonus : Bonus
    {
        protected new double valueBonus;
        protected abstract void SpeedAttackUp();
    }
}

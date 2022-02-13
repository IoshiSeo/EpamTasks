using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Bonuses
{
    class Milk : SpeedAttackBonus
    {
        public Milk()
        {
            valueBonus = 2.0;
        }

        protected override void SpeedAttackUp()
        {
            throw new NotImplementedException();
        }
    }
}

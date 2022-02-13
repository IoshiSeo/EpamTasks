using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Bonuses
{
    class Carrot : SpeedUpBonus
    {
        public Carrot()
        {
            valueBonus = 4;
        }

        protected override void SpeedUp()
        {
            throw new NotImplementedException();
        }
    }
}

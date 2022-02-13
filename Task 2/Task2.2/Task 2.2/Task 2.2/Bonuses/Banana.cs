using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Bonuses
{
    class Banana : HealthUpBonus
    {
        public Banana()
        {
            valueBonus = 20;
        }
        protected override void UpHealth()
        {
            throw new NotImplementedException();
        }
    }
}

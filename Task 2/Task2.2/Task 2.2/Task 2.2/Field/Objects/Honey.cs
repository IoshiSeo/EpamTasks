using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Field.Objects
{
    public class Honey : MyObject
    {
        public Honey()
        {
            damage = 0;
            speedDebuff = 5;
        }
        protected override Coordinates Coordinates { get; set; }
        protected override void AttackPlayer()
        {
            throw new NotImplementedException();
        }

        protected override void ReduceSpeed()
        {
            throw new NotImplementedException();
        }
    }
}

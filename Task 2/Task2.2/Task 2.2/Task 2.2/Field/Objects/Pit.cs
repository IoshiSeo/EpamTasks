using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Field.Objects
{
    public class Pit : MyObject
    {
        public Pit() 
        {
            damage = 20;
            speedDebuff = 0;
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

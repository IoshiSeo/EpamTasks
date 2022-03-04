using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Field.Objects
{
    public abstract class MyObject
    {
        protected int speedDebuff;
        protected int damage;


        protected abstract void ReduceSpeed();
        protected abstract void AttackPlayer();
        protected abstract Coordinates Coordinates { get; set; }

    }
}

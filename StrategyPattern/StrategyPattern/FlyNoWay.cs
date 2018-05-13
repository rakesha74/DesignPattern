using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class FlyNoWay: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I Can't Fly");
        }
    }
}

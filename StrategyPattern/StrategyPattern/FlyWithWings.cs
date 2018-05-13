using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class FlyWithWings: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}

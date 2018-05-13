using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Quack: QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}

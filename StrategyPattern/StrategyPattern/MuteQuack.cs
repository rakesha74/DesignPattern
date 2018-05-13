using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class MuteQuack: QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Silence");
        }
    }
}

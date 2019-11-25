using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class OvenBaking :ICook
    {
        public void Cook(string food)
        {
            Console.WriteLine("Cook Food with OvenBaking");
        }
    }
}

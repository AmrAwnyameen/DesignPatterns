using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    //grilling
    //OvenBaking
    public interface Icock
    {
        void Cook(string food);
    }

    public class grilling : Icock
    {

        void Icock.Cook(string food)
        {
            Console.WriteLine($"Cook {food}  with  grilling");
        }
    }

    public class OvenBakingCock : Icock
    {

        void Icock.Cook(string food)
        {
            Console.WriteLine($"Cook {food}  with  OvenBaking");
        }
    }


    public class CookMethodStrategy
    {
        private readonly string Food;
        private readonly Icock icock;
        public CookMethodStrategy(string food)
        {
            Food = food;
        }

        public void CookFood(Icock icock)
        {
            icock.Cook(Food);
        }
    }

}

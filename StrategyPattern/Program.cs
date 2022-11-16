using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace StrategyPattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Please Write Food Name");
            var food = Console.ReadLine();
            //var cookMethod= new CookMethod();
            //cookMethod.SetFood(food);
            //Console.WriteLine("Please choose your Strategy 1 or 2");
            var strategyNumber = int.Parse(Console.ReadLine());
            CookMethodStrategy cookMethodStrategy = new CookMethodStrategy(food);
            switch (strategyNumber)
            {
                case 1:
                    cookMethodStrategy.CookFood(new grilling());
                    break;
                    
                case 2:
                    cookMethodStrategy.CookFood(new OvenBakingCock());
                    break;
                default:
                        Console.WriteLine("");
                        break;
                    
            }

            Console.ReadLine();


        }
    }
}

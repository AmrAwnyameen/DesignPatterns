using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Please Write Food Name");
            var food = Console.ReadLine();
            var cookMethod= new CookMethod();
            cookMethod.SetFood(food);
            Console.WriteLine("Please choose your Strategy 1 or 2");
            var strategyNumber = int.Parse(Console.ReadLine());
            switch (strategyNumber)
            {
                case 1:
                    cookMethod.SetStrategy(new Grilling());
                    break;
                    
                case 2:
                    cookMethod.SetStrategy(new OvenBaking());
                    break;
                default:
                        Console.WriteLine("");
                        break;
                    
            }

            Console.ReadLine();


        }
    }
}

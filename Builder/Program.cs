using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
     {
            var civilEngineer =new CivilEngineer(new TipiHouseBuilder());
            civilEngineer.ConstructHouse();
            var myHouse = civilEngineer.GetHouse();
            Console.ReadLine();
        }


    }
}

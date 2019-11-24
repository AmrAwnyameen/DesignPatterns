using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var civilEngineer = new CivilEngineer(new TipiHouseBuilder());
            civilEngineer.ConstructHouse();
            Console.WriteLine(civilEngineer.GetHouse()._structure);
            Console.ReadLine();
        }


    }
}

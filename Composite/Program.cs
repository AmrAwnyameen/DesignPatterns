using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //DevelopMent Managers
            var firstdeveloper = new Developer("Cody",15000);
            var developmentDirectories = new CreateDirectory();
            developmentDirectories.AddEmployee(firstdeveloper);


            //Header Managers
            var firstManger = new Manager("Tito", 200000);
            var headerDirectories = new CreateDirectory();
            headerDirectories.AddEmployee(firstManger);

            //All Directories
            var directories= new CreateDirectory();
            directories.AddEmployee(developmentDirectories);
            directories.AddEmployee(headerDirectories);
            directories.ShowDetails();
            Console.ReadLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Manager :IEmployee
    {
        private string Name { get; set; }
        private int Salary { get; set; }

        public Manager(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public void ShowDetails()
        {
            Console.WriteLine(string.Format("Manager Name {0} Salary {1}",this.Name,this.Salary));
        }
    }
}

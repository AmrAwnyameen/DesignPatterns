using System;

namespace Composite
{
   public class Developer :IEmployee
    {
        private string Name { get; set; }
        private int  Salary { get; set; }

        public Developer(string name , int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public void ShowDetails()
        {
            Console.WriteLine(string.Format("Developer Name As Manger {0} Salary {1}", this.Name, this.Salary));

        }
    }
}

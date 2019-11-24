using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class CreateDirectory:IEmployee
    {
        public List<IEmployee> Employees = new List<IEmployee>();

        public void ShowDetails()
        {
            foreach (var employe in Employees)
            {
                employe.ShowDetails();
            }
        }

        public void AddEmployee(IEmployee emp)
        {
            Employees.Add(emp);
            
        }
        
    }
}

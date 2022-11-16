using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerpattern
{
    //Observers
    public interface IResturants
    {
        public void Update(Vigges vigges);
    }

    public class Resturant : IResturants
    {
        private readonly string _Name;

        public Resturant( string name)
        {
            _Name = name;
        }
        public void Update(Vigges veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s "
                           + " price change to {2:C} per pound.",
                           _Name, veggie.GetType().Name, veggie.Price);
        }
    }

   
}

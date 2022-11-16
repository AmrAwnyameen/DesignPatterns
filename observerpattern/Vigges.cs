using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerpattern
{
    //subject
    public abstract class Vigges
    {
        private  double _price;
        private List<IResturants> Resturants = new List<IResturants>();
        public Vigges( double price)
        {
            _price = price;
        }

        public void Add (IResturants resturant)
        {
            Resturants.Add(resturant);
        }

        public void Remove(IResturants resturant)
        {
            Resturants.Remove(resturant);
        }

        public void Notify()
        {
            foreach (var item in Resturants)
            {
                item.Update(this);
            }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; Notify(); }
        }

    }

    public class Carrot : Vigges
    {
        public Carrot(double price) : base(price) { }
    }
}

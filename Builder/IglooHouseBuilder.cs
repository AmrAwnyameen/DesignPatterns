using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class IglooHouseBuilder :IHouseBuilder
   {
       private House _house;

       public IglooHouseBuilder()
       {
           this._house = new House();
       }
        public void BuildBasement()
        {
            _house.SetBasement("Ice Bars");
        }

        public void BuildStructure()
        {
            _house.SetStructure("Ice Structure");
        }

        public void BulidRoof()
        {
            _house.SetRoof("Ice Roof");
        }

        public void BuildInterior()
        {
            _house.SetInterior("ice SetInterio");
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}

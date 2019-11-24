using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class TipiHouseBuilder:IHouseBuilder
    {
        private House _house;

        public TipiHouseBuilder()
        {
            this._house = new House();
        }
        public void BuildBasement()
        {
            _house.SetBasement("TipiHouse Bars");
        }

        public void BuildStructure()
        {
            _house.SetStructure("TipiHouse Structure");
        }

        public void BulidRoof()
        {
            _house.SetRoof("TipiHouse Roof");
        }

        public void BuildInterior()
        {
            _house.SetInterior("TipiHouse SetInterio");
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class CivilEngineer
   {
       private IHouseBuilder _houseBuilder;
        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            this._houseBuilder = houseBuilder;
        }

        public void ConstructHouse()
        {
            _houseBuilder.BuildBasement();
            _houseBuilder.BuildStructure();
            _houseBuilder.BulidRoof();
            _houseBuilder.BuildInterior();
        }
        public House GetHouse()
        {
            return this._houseBuilder.GetHouse();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IHousePlan
    {
         void SetBasement(String basement);

         void SetStructure(String structure);

         void SetRoof(String roof);

         void SetInterior(String interior);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CookMethod
    {
        private string _food;
        private  ICook _icCook;

        public void SetFood(string foodName)
        {
            this._food = foodName;
        }

        public void SetStrategy(ICook cookStrategy)
        {
            cookStrategy.Cook(_food);
        }

    }
}

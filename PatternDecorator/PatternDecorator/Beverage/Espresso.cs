using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Beverage
{
    class Espresso:BeverageBase
    {
        public Espresso()
        {
            description = "Expresso";
        }

        public override double GetPrice()
        {
            //return 35+base.GetPrice();
            return 250;
        }
    }
}

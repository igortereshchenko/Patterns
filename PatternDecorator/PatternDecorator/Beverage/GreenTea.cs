using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Beverage
{
    class GreenTea : BeverageBase
    {
        public GreenTea()
        {
            description = "Green Tea";
        }

        public override double GetPrice()
        {
            return 525;
        }
    }
}

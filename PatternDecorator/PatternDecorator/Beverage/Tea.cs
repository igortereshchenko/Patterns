using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Beverage
{
    class Tea:BeverageBase
    {
        public Tea() {
            description = "Tea";
        }

        public override double GetPrice()
        {
            return 125;
        }

        //public override double GetPrice()
        //{
        //    return 25+base.GetPrice(); ;
        //}

        //public override bool HasMilk()
        //{
        //    return false;
        //}

        //public override bool HasSugar()
        //{
        //    return true;
        //}

        //public override bool HasChocolate()
        //{
        //    return false;
        //}
    }
}

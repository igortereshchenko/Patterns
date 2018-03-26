using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Beverage
{
    class Capuccino:BeverageBase
    {
        public Capuccino()
        {
            description = "Capuccino";
        }

        public override double GetPrice()
        {
            //return 35+base.GetPrice();
            return 250;
        }

        //public override bool HasMilk()
        //{
        //    return true;
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

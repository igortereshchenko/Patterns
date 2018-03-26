using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Beverage
{
    class HotChocolate:BeverageBase
    {
        public HotChocolate()
        {
            description = "HotChocolate";
        }


        public override double GetPrice()
        {
            return 225;
        }

        //public override double GetPrice()
        //{
        //    return 40+base.GetPrice(); ;
        //}

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
        //    return true;
        //}
    }
}

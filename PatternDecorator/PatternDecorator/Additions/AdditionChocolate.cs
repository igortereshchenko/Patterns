using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDecorator.Beverage;

namespace PatternDecorator.Additions
{
    class AdditionChocolate:AdditionsDecoratorBase
    {   
        private BeverageBase beverage;

        public AdditionChocolate(BeverageBase beverage_)
        {

            beverage = beverage_;
            description = beverage.GetDescription() + " with chocolate ";
        }

        public override double GetPrice()
        {
            return beverage.GetPrice() + 60;
        }
    }
}

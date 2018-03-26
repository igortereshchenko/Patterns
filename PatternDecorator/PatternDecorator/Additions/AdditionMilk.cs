using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDecorator.Beverage;

namespace PatternDecorator.Additions
{
    class AdditionMilk:AdditionsDecoratorBase
    {
        private BeverageBase beverage;

        public AdditionMilk(BeverageBase beverage_) {

            beverage = beverage_;
            description = beverage.GetDescription() + " with milk ";
        }

        public override double GetPrice()
        {
            return beverage.GetPrice() + 40;
        }
    }
}

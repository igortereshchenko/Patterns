using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDecorator.Beverage;

namespace PatternDecorator.Additions
{
    class AdditionSugar:AdditionsDecoratorBase
    {
        private BeverageBase beverage;

        public AdditionSugar(BeverageBase beverage_)
        {

            beverage = beverage_;
            description = beverage.GetDescription() + " with sugar ";
        }

        public override double GetPrice()
        {
            return beverage.GetPrice() + 50;
        }
    }
}

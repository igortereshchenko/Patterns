using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Beverage
{
    public abstract class BeverageBase
    {
        protected string description = "";
        //protected double milk_price = 50;
        //protected double sugar_price = 50;
        //protected double cholocate_price = 50;

        public string GetDescription() {
            return description;
        }


        public abstract double GetPrice();


        //public virtual double GetPrice() { 

        //    double cost = 0;
        //    if (HasMilk())
        //        cost += milk_price;

        //    if (HasSugar())
        //        cost += sugar_price;

        //    if (HasChocolate())
        //        cost += cholocate_price;

        //    return 200+cost;
        //}

        //public abstract bool HasMilk();
        //public abstract bool HasSugar();
        //public abstract bool HasChocolate();

    }
}

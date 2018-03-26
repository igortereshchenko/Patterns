using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDecorator.Beverage;
using PatternDecorator.Additions;

namespace PatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase capuccino = new Capuccino();
            BeverageBase tea = new Tea();
            BeverageBase hot_chololate = new HotChocolate();
            BeverageBase espresso = new Espresso();


            List<BeverageBase> beverage_list= new List<BeverageBase>();

            beverage_list.Add(capuccino);
            beverage_list.Add(tea);
            beverage_list.Add(hot_chololate);
            beverage_list.Add(espresso);


            foreach (BeverageBase beverage in beverage_list){

                    Console.WriteLine("Beverage: {0}, price: {1}",beverage.GetDescription(),beverage.GetPrice());
                    Console.WriteLine();
            }




            Console.WriteLine("______________________________");




            BeverageBase green_tea = new GreenTea();


            BeverageBase capuccino2 = new AdditionSugar(new AdditionMilk(new Espresso()));


            beverage_list.Add(capuccino2);


            foreach (BeverageBase beverage in beverage_list)
            {

                Console.WriteLine("Beverage: {0}, price: {1}", beverage.GetDescription(), beverage.GetPrice());
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}

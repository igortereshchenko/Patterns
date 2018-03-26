using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternFactory.Facilities;
using PatternFactory.Factory;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory factory = new SimpleFactory();

           // VolkswagenFacility volkswagen_car = new VolkswagenFacility(factory);

            VolkswagenFacility volkswagen_car = new UaVolkswagenFacility();


            volkswagen_car.GetCar("Golf");
            Console.WriteLine("_____________________________________");

            volkswagen_car = new ChinaVolkswagenFacility();
            volkswagen_car.GetCar("Passat");
            Console.ReadKey();

        }
    }
}

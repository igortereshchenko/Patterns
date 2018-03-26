using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternFactory.Factory;
using PatternFactory.Cars;


namespace PatternFactory.Facilities
{
    abstract class VolkswagenFacility
    {

        private SimpleFactory factory;
        public VolkswagenFacility(SimpleFactory factory_)
        {
            factory = factory_;
        }

        public VolkswagenFacility()
        {
 
        }
        public Cars.Car GetCar(string type)
        {

            Cars.Car car;
            //if (type == "Golf")
            //    car = new Cars.Golf();
            //else if (type == "Passat")
            //    car = new Cars.Passat();
            //else
            //    car = new Cars.Car();

           // car = factory.GetCar(type);


            car = CreateCar(type); //new version


            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;

            
        }
        public abstract Car CreateCar(string type);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Facilities
{
    class UaVolkswagenFacility:VolkswagenFacility
    {
        public override Cars.Car CreateCar(string type)
        {
            Cars.Car car;
            if (type == "Golf")
                car = new Cars.UaGolf();
            else if (type == "Passat")
                car = new Cars.UaPassat();
            else
                car = new Cars.Car();

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }
    }
}

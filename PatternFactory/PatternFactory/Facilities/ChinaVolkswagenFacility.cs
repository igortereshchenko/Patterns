using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Facilities
{
    class ChinaVolkswagenFacility:VolkswagenFacility
    {
        public override Cars.Car CreateCar(string type)
        {
            Cars.Car car;
            if (type == "Golf")
                car = new Cars.ChinaGolf();
            else if (type == "Passat")
                car = new Cars.ChinaPassat();
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

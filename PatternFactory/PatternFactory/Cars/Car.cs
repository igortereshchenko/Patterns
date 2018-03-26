using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Cars
{
    public class Car
    {
        protected string name = "";
        protected string body = "";
        protected string wheels = "standart 4 wheels";
        protected string color = "white";
        protected string engine = "dissel";

        public void Configure()
        {
            Console.WriteLine("name: {0}",name);
            Console.WriteLine("body: {0}", body);
            Console.WriteLine("wheels: {0}", wheels);
            Console.WriteLine("color: {0}", color);
            Console.WriteLine("engine: {0}", engine);
        }

        public void AssembleBody()
        {
            Console.WriteLine("Body is assembling");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Engine is installing");
        }

        public void Paint()
        {
            Console.WriteLine("Car is painting");
        }

        public void InstallWheels()
        {
            Console.WriteLine("Wheels is installing");
        }


    }
}

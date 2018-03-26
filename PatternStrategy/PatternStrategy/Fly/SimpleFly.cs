using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Fly
{
    class SimpleFly:IFlyabale
    {
        public void Fly() {
            Console.WriteLine("I'm have flying");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStrategy.Duck;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<BaseDuck> ducks=new List<BaseDuck>();

            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());

            foreach (var duck in ducks) {

                duck.Display();
                duck.Quack();
                duck.Fly();
                
                Console.WriteLine();
            }


            

            Console.ReadKey();
        }
    }
}

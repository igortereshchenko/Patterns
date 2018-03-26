using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStrategy.Fly;
using PatternStrategy.Quack;

namespace PatternStrategy.Duck
{
    public abstract class BaseDuck
    {
        public IFlyabale flybehaviour;
        public IQuackable quackbehaviour;

        public BaseDuck() {
            flybehaviour = new SimpleFly();
            quackbehaviour = new SimpleQuack();
        }

        public void Quack() {
            quackbehaviour.Quacks();
        }

        public void Smiw() {
            Console.WriteLine("I'm swiming");
        }

        public void Fly() {
            flybehaviour.Fly();
        }

        public abstract void Display();
    }
}

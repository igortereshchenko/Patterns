﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Quack
{
    class SimpleQuack:IQuackable
    {
        public void Quacks() {
            Console.WriteLine("Quack! Quack!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {

        public Bird(string feahterType, bool fly, string beakType, int howManyEggs )
        {
            WingsandFeathers = feahterType;
            Canfly = fly;
            Beak = beakType;
            Eggs = howManyEggs;
        }
        public string WingsandFeathers { get; set; }

        public bool Canfly { get; set; }

        public string Beak { get; set; }

        public int Eggs { get; set; }

        public string OutputFly()
        {
            return Canfly ? "Can" : "Cannot";
        }

    }
}

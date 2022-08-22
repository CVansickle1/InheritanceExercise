using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool Existence { get; set; }

        public string WhereTheyLive { get; set; } = "United States";

        public string ExteriorBody { get; set; }

        public int HaveLegs { get; set; }

        public string IsExtinct()
        {
             return Existence ? "is extinct" : "is not extinct";
        }

    }
}

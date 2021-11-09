using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    class Cirkel:Teckning

    {

        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 4;
        }

        public override double Area()
        {
            Console.Write("Cirkelns area är = ");
            return Radius*Radius*3.14;
        }
    }
}

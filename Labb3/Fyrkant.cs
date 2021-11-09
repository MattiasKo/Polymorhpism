using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    class Fyrkant:Teckning
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Fyrkant()
        {
            Height = 2;
            Width = 3;
        }
        public override double Area()
        {
            Console.Write("Fyrkantens area är = ");
            return Height*Width;
        }
    }
}

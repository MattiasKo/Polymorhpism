using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3 
{
    class Rektangel : Teckning
    {
        public int Height{get;set;}
        public int Width { get; set; }

        public Rektangel()
        {
            Height = 6;
            Width = 4;
        }
        public override double Area()
        {
            Console.Write("Rektangeln area är = ");
            return Height*Width/2;
        }
    }
}

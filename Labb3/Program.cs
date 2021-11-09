//Mattias Kokkonen SUT21
using System;

namespace Labb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning[] Areas = new Teckning[4];
            Areas[0] = new Teckning();
            Areas[1] = new Rektangel();
            Areas[2] = new Fyrkant();
            Areas[3] = new Cirkel();
            

            foreach (Teckning a in Areas)
            {
                Console.WriteLine(a.Area());
            }

            Teckning F1 = new Fyrkant();
            Teckning C1 = new Cirkel();
            Teckning R1 = new Rektangel();
            Console.WriteLine( R1.Area());
            Console.WriteLine( F1.Area() );
            Console.WriteLine( C1.Area());




        }
    }
}

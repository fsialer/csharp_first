using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo.Models
{
    public class Color : Recurso
    {


        public override void rojo() {
            Console.WriteLine("Color rojo");
        }
        public override void azul()
        {
            Console.WriteLine("Color azul");
        }
    }
}

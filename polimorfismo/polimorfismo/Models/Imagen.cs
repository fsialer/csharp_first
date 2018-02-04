using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo.Models
{
    public class Imagen:Recurso
    {
        public override void png() {
            Console.WriteLine("imagen png");
        }
        public override void jpg() {
            Console.WriteLine("Color jpg");
        }
    }
}

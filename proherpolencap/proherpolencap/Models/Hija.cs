using System;
using System.Collections.Generic;
using System.Text;

namespace proherpolencap.Models
{
    public class Hija : Padre
    {
        public Hija(string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
        }

        public override void padre()
        {
            Console.WriteLine(nombre + " " + apellido + " " + edad);
        }
    }
}

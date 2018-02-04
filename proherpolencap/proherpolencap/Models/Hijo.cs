using System;
using System.Collections.Generic;
using System.Text;

namespace proherpolencap.Models
{
    public class Hijo : Padre
    {
        public Hijo(string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
        }

        public override void padre()
        {            
            Console.WriteLine(nombre + " " + apellido + " " + edad);
        
        }
    }
}

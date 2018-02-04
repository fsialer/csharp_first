using proherpolencap.Models;
using System;

namespace proherpolencap
{
    class Program
    {
        static void Main(string[] args)
        {
            Padre p;
            p = new Hija("Klaudia","Sialer",26);
            p.padre();
          
            p = new Hijo("Renzo", "Sialer", 26);
            p.padre();
           

            // h.informacion("Juan","Guatierrez",13);
            // h.informacion();
            //p.Edad = 24;

            Console.ReadKey();

        }
    }
}

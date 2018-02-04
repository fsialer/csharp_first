using polimorfismo.Models;
using System;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Recurso r;
            r = new Color();
            r.azul();
            r.rojo();
            r = new Imagen();
            r.png();
            Console.ReadKey();
        }
    }
}

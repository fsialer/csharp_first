using Enumeradores.Models;
using System;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Colores color = (Colores)Enum.Parse(typeof(Colores),"Amarillo");
            Array color2 = Enum.GetValues(typeof(Colores));
            string[] color3 = Enum.GetNames(typeof(Colores));
            /*int amarillo = (int)Colores.Amarillo;
            int rojo = (int)Colores.Rojo;
            Console.WriteLine(color+" "+amarillo+ " "+rojo);*/
            switch (color)
            {
                case Colores.Amarillo:
                    int x = (int)Colores.Amarillo;
                    Console.WriteLine(color + "={0}",x);
                    break;
                case Colores.Azul:
                    break;
                case Colores.Rojo:
                    int y = (int)Colores.Rojo;
                    Console.WriteLine(color + "={0}", y);
                    break;
                case Colores.Verde:
                    break;
                
            }

            foreach (var item in color2)
            {
                Console.WriteLine(item);
            }

            foreach (var item in color3)
            {
                Console.WriteLine(item);
            }

            Colores c = Colores.Amarillo;
            if (c.Equals(Colores.Amarillo))
            {
                Console.WriteLine("Afirmativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }



            Console.ReadKey();
        }
    }
}

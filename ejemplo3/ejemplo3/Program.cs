﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = "232";
            DateTime fecha = DateTime.MinValue;
            //i = (int)x;
            i = Convert.ToInt32(cadena);
            Console.WriteLine("El valor de i es: {0}",i);
            Console.WriteLine("El valor de x es: {0:C}",x);
            Console.WriteLine("El valor de bandera es :"+bandera.ToString());
            Console.WriteLine("El valor de cadena es "+cadena);
            Console.WriteLine("El valor de fecha es: "+fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}

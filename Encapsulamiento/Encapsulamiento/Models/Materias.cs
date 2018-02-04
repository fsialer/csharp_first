using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento.Models
{
    public class Materias
    {
        private string nombre;
        private static int primero;
        private static int segundo;
        private static int tercero;
        private static int cuarto;
        private static int nota;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Primero { get => primero; set => primero = value; }
        public int Segundo { get => segundo; set => segundo = value; }
        public int Tercero { get => tercero; set => tercero = value; }
        public int Cuarto { get => cuarto; set => cuarto = value; }
        public int Nota { get => nota; set => nota = value; }

        public void alumno()
        {
            nota = primero + segundo + tercero + cuarto;
            Console.WriteLine("Alumno "+nombre+
                "\nPrimer Trimestre: " +primero+
                "\nSegundo Trimestre: " + segundo +
                "\nTercero Trimestre: " + tercero +
                "\nCuarto Trimestre: " + cuarto +
                "\nNota del alumno: " + nota +"\n\n" );
        }
    }
}

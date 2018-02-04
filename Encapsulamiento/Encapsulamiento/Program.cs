using Encapsulamiento.Models;
using System;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Materias m = new Materias();
            m.Nombre = "Fernando";
            new Primero();
            new Segundo();
            new Tercero();
            new Cuarto();
            m.alumno();
            Console.ReadKey();
        }
    }
}

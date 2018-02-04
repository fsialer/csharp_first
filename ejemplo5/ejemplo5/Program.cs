using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.edad = 26;
            empleado.nombre = "Fernando";
            empleado.sueldoMensual = 200.00m;
            empleado.Nombre = "hola";
            decimal result = empleado.calculaSalario(30);
            Console.WriteLine("El salario mensual del empleado "+ empleado.nombre);
            Console.WriteLine("es: "+result.ToString("C"));
            Console.WriteLine("es: " + empleado.Nombre);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Sialer Ayala";
            Cliente.Nombres = "Fernando";
            Cliente.RFC = "HEHH";
            Cliente.Direccion = "lima 032";
            Cliente.Colonia = "Pimentel";
            Cliente.Municipio = "DSeF";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos+" "+Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion+" "+Cliente.Colonia+" "+Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito");
            }
            Console.ReadKey();


        }
    }
}

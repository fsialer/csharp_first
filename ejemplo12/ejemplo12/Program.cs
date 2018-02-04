using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo12
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            List<clsClientesBase> Clientes;
            Clientes = new List<clsClientesBase>();
            while(opcion != "s")
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("a. Agregar a la lista");
                Console.WriteLine("b. Quitar de la lista");
                Console.WriteLine("c. Imprimir Lista");
                Console.WriteLine();
                Console.WriteLine("s. Salir");
                opcion = Console.ReadLine();
                if (opcion=="a")
                {
                    string cadena = Console.ReadLine();
                    clsClientesBase Cliente = new clsClientesBase();
                    Cliente.Id = Clientes.Count + 1;
                    Cliente.Nombre = cadena;
                    Clientes.Add(Cliente);
                }else if (opcion == "b")
                {
                    string cadena = Console.ReadLine();
                    Clientes.RemoveAt(Convert.ToInt32(cadena));

                }else if(opcion == "c")
                {
                    Console.WriteLine("Los datos del cliente son: ");
                    foreach (clsClientesBase item in Clientes)
                    {                       
                        Console.WriteLine(item.Id.ToString() + " "+item.Nombre);
                    }
                }
            }
        }
    }
}

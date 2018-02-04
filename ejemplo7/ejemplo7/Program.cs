using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*clsClientesBase cliente = new clsClientesBase(0,"Fernando Sialer",
                "001","HEHM",1,"Fernando Sialer");*/
            clsClientesConContacto cliente;
            cliente = new clsClientesConContacto(0, "Fernando Sialer",
            "001", "HEHM", 1, "Fernando Sialer", "637573", "4344434", "alexis_s309@hotmail.com", "Av. lima", "139", "", "La cueva del inca :v", "A.v octubre", "provivienda",
            "23432");

            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena=="1")
            {
                Impresion = new clsImpresion();
            }
            else
            {
                Impresion = new clsArchivo();
            }            
            Impresion.imprimirCliente(cliente);
          
            
        }
    }
}

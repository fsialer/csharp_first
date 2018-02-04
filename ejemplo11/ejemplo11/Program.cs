using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo11
{
    class Program
    {
        static void Main(string[] args)
        {
            //clsMostrarArrayList Lista = new clsMostrarArrayList();
            //Lista.CapturarDatos();
            //Lista.ImprimirDatos();
            clsMostrarHashTable ListaH = new clsMostrarHashTable();
            ListaH.AgregarDatos();
            ListaH.ImprimirDatos();
            ListaH.eliminarElemento("C001");
            ListaH.ImprimirDatos();
        }
    }
}

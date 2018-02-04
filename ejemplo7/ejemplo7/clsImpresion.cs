using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo7
{
    class clsImpresion : intSalidas
    {
        public void immprimirDireccion(clsDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle + " " + direccion.Colonia);
            Console.WriteLine(direccion.Estado);
            Console.WriteLine(direccion.CP);
            Console.ReadKey();
        }

        public void imprimirCliente(clsAbsClientes cliente)
        {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();

        }
    }
}

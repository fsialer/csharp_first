using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo7
{
    class clsArchivo : intSalidas
    {
        public void immprimirDireccion(clsDirecciones direccion)
        {
           
        }

        public void imprimirCliente(clsAbsClientes cliente)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\fernando\Desktop\ejemplo.txt", true);
            ar.WriteLine(cliente.Clave + " "+cliente.Nombre);
            if (cliente.TipoRegimen == 1)
            {
                ar.WriteLine("Tipo: Persona Fisica");
            }
            else
            {
                ar.WriteLine("Tipo: Persona Moral");                        
            }
            ar.WriteLine("RFC" + cliente.RFC);
            ar.Close();
        }
    }
}

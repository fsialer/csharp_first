using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo8
{
    public class clsArchivo : intSalidas
    {
        public void immprimirDireccion(clsDirecciones direccion)
        {
           
        }

        public void imprimirCliente(clsAbsClientes cliente)
        {
            bool bandera = true;
            int i = 0;
            while (bandera)
            {
                try
                {
                    StreamWriter ar = new StreamWriter(@"C:\Users\fernando\Desktop\ejemplo.txt", true);
                    ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
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
                    bandera = false;
                }
                catch (Exception e)
                {
                    i++;
                    if (i>=1000)
                    {
                        throw e;
                    }
                    
                }
            }
            
            
        }
    }
}

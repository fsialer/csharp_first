using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo13
{
    class clsProductosInventario
    {
        public int IdProducto { get;  set; }
        public string Clave { get;  set; }
        public string Descripcion { get;  set; }
        public decimal PrecioPublico { get;  set; }
        public decimal Costo { get;  set; }
        public int Existencias { get;  set; }
    }
}

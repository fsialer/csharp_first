using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo13
{
    class ctrEjemplo13
    {
        public ctrEjemplo13()
        {
            _Productos = new List<clsProductosInventario>();
        }
        private List<clsProductosInventario> _Productos;

        public List<clsProductosInventario> Productos { get; set; }
        
       

        public void llenarLista()
        {
            Productos.Clear();
            Productos.Add(new clsProductosInventario() {
                IdProducto = 124,
                Clave ="P0001",
                Descripcion="GTA Crackets 200g",
                PrecioPublico =23.0m,
                Costo=11.5m,
                Existencias =0
            });

            Productos.Add(new clsProductosInventario()
            {
                IdProducto = 125,
                Clave = "P0022",
                Descripcion = "Leche Gloria 200ml",
                PrecioPublico = 2.0m,
                Costo = 3.5m,
                Existencias = 0
            });
            Productos.Add(new clsProductosInventario()
            {
                IdProducto = 126,
                Clave = "P0038",
                Descripcion = "galletas oreo 100g",
                PrecioPublico = 16.0m,
                Costo = 18.5m,
                Existencias = 0
            });

        }


    }
}

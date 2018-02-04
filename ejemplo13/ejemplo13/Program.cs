using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch reloj = new Stopwatch();
            ctrEjemplo13 ctr1 = new ctrEjemplo13();
            ctr1.llenarLista();
            Impresion.ImprimeProductos(ctr1.Productos);
            Impresion.EsperaTecla();
            List<clsProductosInventario> lista = new List<clsProductosInventario>();
            reloj.Start();
            foreach (var item in ctr1.Productos)
            {
                if (item.Existencias > 0 && item.PrecioPublico<12)
                {
                    lista.Add(item);
                }
            }
            reloj.Stop();
            Impresion.ImprimeProductos(lista);
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();
            List<clsProductosInventario> lista2 = new List<clsProductosInventario>();
            reloj.Reset();
            reloj.Start();
            lista2.AddRange(from o in ctr1.Productos where o.Existencias <= 0 select o);
            reloj.Stop();
            Impresion.ImprimeProductos(lista2);
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();
            var lista3 = (from o in ctr1.Productos group o by o.Costo into g select new { g.Key, Total=g.Sum(t=>t.Existencias*t.PrecioPublico)}).ToList();
            foreach (var item in lista3)
            {
                Console.WriteLine("Total :{0} Costo: {1}",item.Total,item.Key);
            }
            Impresion.EsperaTecla();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    public class clsEmpleados
    {
        public string nombre;
        public decimal sueldoMensual;
        public int edad;
        private string _nombre;
        

        public clsEmpleados()
        {
            nombre = "";
            sueldoMensual = 0.0m;
            edad = 0;
        }
        public decimal SueldoMensual{ get; set; }

        public int Edad { get; set; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public decimal calculaSalario(int numeroDias)
        {
            return sueldoMensual * numeroDias;
        }

    }
}

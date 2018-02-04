using System;
using System.Collections.Generic;
using System.Text;

namespace proherpolencap.Models
{
    public abstract class Padre
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Padre(string nombre,string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public Padre(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            
        }

        public void informacion(string nombre,string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public void informacion(string nombre ="Fconsulting", string apellido="SA")
        {
            this.nombre = nombre;
            this.apellido = apellido;
            
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public int Edad {
            get => edad;
            set => edad = value;
        }

        public abstract void padre();
    }
}

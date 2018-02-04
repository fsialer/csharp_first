using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas
{
    class Program
    {
        private Nodo primero;
        private int size;
        public Program()
        {
            this.primero = null;
            this.size = 0;
        }

        public void ListaVacia()
        {
            if (this.primero==null)
            {
                Console.WriteLine("La lista esta vacio");
            }
            else
            {
                Console.WriteLine("La lista tiene datos");
            }
        }

        public int Size()
        {
            return size;
        }

        public void listar()
        {
            Nodo actual = primero;
            while (actual!=null)
            {
                Console.WriteLine("["+actual.dato+"]->");
                actual = actual.siguiente;
            }
        }

        public void agregarNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato); //Agregar el nodo
            nuevo.siguiente = primero; // ir al primer nodo
            primero = nuevo; //lo coloca de primero
            size++;
        }
        static void Main(string[] args)
        {
            Program lista=new Program();
            lista.ListaVacia();
            lista.agregarNodo(1);
            lista.agregarNodo(2);
            lista.agregarNodo(3);
            lista.agregarNodo(4);
            lista.agregarNodo(5);
            lista.listar();
            Console.WriteLine("Tamaño " + lista.Size());
            lista.ListaVacia();
            Console.ReadLine();
        }
    }
}

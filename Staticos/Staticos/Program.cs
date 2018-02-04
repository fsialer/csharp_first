using System;

namespace Staticos
{
    class Program
    {
        private static string nombre;
        private readonly string nombre2="Hola";
        private const string nombre3 = "Hola2";
        private static void metodo1()
        {
            nombre = "Fernando";
            Console.WriteLine("Soy un metodo estatico, mi nombre es"+nombre);
        }
        
        private static void metodo3(out string name,out int age)
        {
            name = "Frank";
            age = 37;
        }

        public Program()
        {

        }

        private string metodo2()
        {
            nombre = "Juan";
            return nombre;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string nombre;
            int edad;
            Program.metodo3(out nombre,out edad);
            Console.WriteLine(nombre+" "+edad);
            Console.WriteLine(p.metodo2());
            
            Program.metodo1();
            Console.ReadKey();
        }
    }
}

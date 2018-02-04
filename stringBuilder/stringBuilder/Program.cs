using System;
using System.Text;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            StringBuilder sb = new StringBuilder();
            sb.Append("Curso de C#").Append("desde cero").AppendLine("nuevo dato").Append(true);
            sb.Insert(9,"hola");
            sb.Remove(9,5);
            cadena = sb.ToString();
            Console.WriteLine(cadena);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Expresiones_regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string patron;
            patron = "Alex";
            String[] textos =
            {
                "C# Alex",
                "C# Fer"
            };
            foreach (string s in textos)
            {
                Console.Write("{0}", s);
                //InsMatch indica si al expresion regular especificada en el constructor Regex
                //encuentra una coincidencia en una cadena de entrada indicada

                //IgnoreCase especifica la coincidencia con distincion entre mayusculas y minusculas
                if (Regex.IsMatch(s,patron,RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("  {0} encontrado",patron);
                }
                else
                {
                    Console.WriteLine();
                }
            }
            //patron = "\\s+";//Para buscar coincidencias de espacio en blanco
            //string input = "Esto   es    un   texto   con   demasiado " +
            //    "espacio  en  blanco";
            //string replace = " ";
            //Regex rgx = new Regex(patron);
            //string result = rgx.Replace(input, replace);
            //Console.WriteLine("Original String: {0}",input);
            //Console.WriteLine("Reemplazo String: {0}", result);
            //patron = "[0-9]+";
            //string[] cadena = { "uno1dos2tres3cuatro" };
            //foreach (var texto in cadena)
            //{
            //    Console.WriteLine(Regex.Replace(texto,patron,"\n"));
            //}
            Console.ReadKey();
        }
    }
}

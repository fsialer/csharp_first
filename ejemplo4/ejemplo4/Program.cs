using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0,num2=0;
            string cadena;
            Console.WriteLine("dame el primer valor");
            cadena = Console.ReadLine();
            num1 = Convert.ToInt32(cadena);
            Console.WriteLine("dame el segundo valor");
            cadena = Console.ReadLine();
            num2 = Convert.ToInt32(cadena);
            if (num1>num2)
               Console.WriteLine("Es mayor");            
            else
               Console.WriteLine("Es menor");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[4];
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = 12;
            }
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine("{0}", Arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}

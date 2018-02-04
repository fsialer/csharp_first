using System;

namespace funcionLocal
{
    class Program
    {
        static void Main(string[] args)
        {
           
            void funcion1()
            {
                Console.WriteLine("Hello World!");
                funcion2();
            }

            void funcion2()
            {
                Console.WriteLine("Alex");
            }

            funcion1();
            Console.ReadKey();
        }


    }
}

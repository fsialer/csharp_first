using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine("Ingrese un numero del 0 al 4");

                int valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El valor en el array es : {0}",array[valor]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un dato de tipo entero");
            }
            catch (Exception e)
            //catch(FormatException e)
            {

                Console.WriteLine("Debe ingresar un numero del 0 al 4");
            }
            finally
            {
                Console.WriteLine("Instrucciones si se producen errores como sino");
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace ejemplo15
{
    class Program
    {
        /*En C# .NET CORE, un delegado es una estructura de datos que hace
         referencia a un metodo estático o a un metodo de instancia*/
        private delegate int calculadora(int x, int y);
        private delegate void Mensajes(string m);
        /*Func maneja muchos argumentos, Func es un tipo parametrizado. Especificamos
         el numero y tipo de parametros, y el tipo del valor de retorno. El tipo func
         proporciona una manera de almacenar meodos anonimos de manera generalizada y
         simple.*/
        Func<bool, int, string> func;
        /*Accion objetos devuelven ningun valor. El tipo de aciones es similiar a un metodo de vacio. Nunca 
         debe devolver un valor en la pila de evaluacion*/
        Action<int, int> act;
        /*Predicado. un predicado devuelven verdadero o falso. El tipo de predicado en el 
         lenguaje C# almacena un metodo que recibe un parametro y devuelve un valor de
         verdadero o falso. Y se utiiza a menudo con la sintaxis de expresiones lambda.*/
        Predicate<Datos> pdt;
        static void Main(string[] args)
        {
            /*Las expresiones lambda son simples metodos/funciones, con una sintaxis
             diferente, con lo cual pueden ser escritas en expresiones de contexto
             (params)=>expresion*/

            Program obj = new Program();
            obj.func = (a, j) => { return string.Format("cadena = {0} y {1}", a, j); };
            Console.WriteLine(obj.func.Invoke(true, 50));
            obj.act = (a, j) => { Console.WriteLine("Datos de tipo entero {0} y {1}", a, j); };
            obj.act.Invoke(1,2);
            Datos d = new Datos();
            d.Cantidad = 45;
            d.Texto = "Fernando";
            obj.pdt = x => { return x.Texto.Equals("Fernando"); };
            Console.WriteLine(obj.pdt.Invoke(d));
            //calculadora cal = (x, y) => x * y;
            //Console.WriteLine(cal(15,13));
            //Mensajes miMensaje = (m) => { Console.WriteLine("hola como estan" + m); };
            //miMensaje("Fernando");
            Console.ReadKey();
        }
    }
}

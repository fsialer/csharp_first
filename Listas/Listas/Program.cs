using Listas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Books<String> libro = new Books<String>();
            libro.Book = "Comedia";
            Console.WriteLine(libro.Book);
            /*
            // List<string> list = new List<string>();
           // List<Frutas> list,list2;
           //  list = new List<Frutas>();
            //Frutas f=new Frutas {
               // Id = 1,
             //   Fruta = "Manzana"
            //};
            //list.Add(f);
            //Frutas f2 = new Frutas
            //{
              //  Id = 2,
                //Fruta = "Pera"
            //};
            //list.Add(f2);
            //Frutas f3 = new Frutas
            {
                Id = 3,
                Fruta = "Uva"
            };
            list.Add(f3);
            Frutas f4 = new Frutas
            {
                Id = 4,
                Fruta = "Banana"
            };
            list.Add(f4);*/
            //list2 = list.Where(fr => fr.Id > 2).ToList();
            //list2 = list.Skip(2).ToList();
            //list2 = list.Take(3).ToList();
            //list2 = list.OrderBy(fr=>fr.Fruta).ToList();//ordena el arreglo por objetos
            //list2 = list.Where(fr=>fr.Fruta.StartsWith("P")).ToList();
            //list.ForEach(item => Console.WriteLine(item.Fruta));
            //list2.ForEach(item => {
            //    Console.WriteLine(item.Id + " - " + item.Fruta);
            //});
            /* list.Add("Alexis");
             list.Add("Sebastiam");
             list.Add("Nancy");
             //list.Clear();
             list.Insert(1,"Roland");//se inserta un elemento en un posicion haciendo que los demas elementos se desplacen
             list.Reverse();//invertir posicion de los elementos del arreglo
             list.Sort();//ordernar arreglo
             list.Remove("Roland");//Remueve un elemento del arreglo
             Console.WriteLine(list.IndexOf("Nancy"));//devuelve la posicion del elemento
             list.ForEach (item => Console.WriteLine(item)) ;
             //foreach (var item in list)
            // {
              //   Console.WriteLine(item);
             //}
             //Console.WriteLine(list.LastIndexOf("Sebastiam"));

             Console.WriteLine(list.Contains("Roland"));
             **/
            Console.ReadKey();
        }
    }
}

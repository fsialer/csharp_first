using interfaces.Models;
using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            //animal = new Cat("gato");
            //animal.run();
            animal = new Dog();
            animal.Name="Perro";
            animal.run();
            Console.ReadKey();

        }
    }
}

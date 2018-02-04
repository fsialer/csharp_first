using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces.Models
{
    public class Cat : Animal
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public override string Name { get => name; set => name = value; }

        public override void jump()
        {
            Console.WriteLine("El "+name+" salta");
        }

        public override void run()
        {
            Console.WriteLine("El " + name + " corre");
        }
    }
}

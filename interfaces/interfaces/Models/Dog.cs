using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces.Models
{
    public class Dog : Animal
    {
        private string name;
        public override string Name { get => name; set => name=value; }

        public override void jump()
        {
            Console.WriteLine("El " + name + " salta");
        }

        public override void run()
        {
            Console.WriteLine("El " + name + " corre");
        }
    }
}

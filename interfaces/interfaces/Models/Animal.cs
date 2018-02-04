using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces.Models
{
    public abstract class Animal : Habilidades
    {
        public abstract string Name { get; set; }

        public abstract void jump();
        public abstract void run();
    }
}

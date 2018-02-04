using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces.Models
{
    interface Habilidades
    {
        string Name { get; set; }
        void run();
        void jump();
    }
}

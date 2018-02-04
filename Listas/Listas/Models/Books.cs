using System;
using System.Collections.Generic;
using System.Text;

namespace Listas.Models
{
    public class Books<T>
    {
        private T book;
        public T Book { get{ return book;}
        set{ book = value; }
        }
    }
}

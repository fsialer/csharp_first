using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoo
{
    public class Tareas
    {
        private string name;
        private int second;

        public Tareas(String name,int second)
        {
            this.name = name;
            this.second = second;
        }

        public void tarea1()
        {
            Console.WriteLine(name+"Esta tarea solo tendra "+second+" second .");
            Thread.Sleep(second*1000);
            Console.WriteLine("Tarea terminada: "+name);
        }

        //public void tarea2()
        //{
        //    Console.WriteLine(name + "Esta tarea solo tendra " + second + " second .");
        //    Thread.Sleep(second * 1000);
        //    Console.WriteLine("Tarea terminada: " + name);
        //}
    }
}

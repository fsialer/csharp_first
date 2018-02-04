using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaTarea = new ArrayList();
            listaTarea.Add("Hilo_1");
            listaTarea.Add("Hilo_2");
            listaTarea.Add("Hilo_3");
            ArrayList listaSecond = new ArrayList();
            listaSecond.Add(8);
            listaSecond.Add(16);
            listaSecond.Add(24);
            for (int i = 0; i < listaTarea.Count; i++)
            {
                object tarea = listaTarea[i];
                string tareas = Convert.ToString(tarea);
                object secs = listaSecond[i];
                int sec = Convert.ToInt32(secs);
                Tareas Obj1 = new Tareas(tareas,sec);
                Obj1.tarea1();
            }
            //Tareas Obj1 = new Tareas("Hilo_1", 8);
            //Tareas Obj2 = new Tareas("Hilo_2", 16);
            //Thread hilo = new Thread(Obj1.tarea1);
            //Thread hilo2 = new Thread(Obj2.tarea2);
            //hilo.Start();
            //hilo2.Start();
            Console.ReadKey();
        }
    }
}

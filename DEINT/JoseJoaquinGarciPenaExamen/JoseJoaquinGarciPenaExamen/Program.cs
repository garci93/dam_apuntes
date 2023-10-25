using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Program
    {
        static Queue<Tarea> tareas = new Queue<Tarea>();
        static Stack<Tarea> tareasCompletadas = new Stack<Tarea>();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca nombre de tarea");
            AgregarTarea(Console.ReadLine());
            Console.WriteLine("Introduzca nombre de tarea");
            AgregarTarea(Console.ReadLine());
            Console.WriteLine("Introduzca nombre de tarea");
            AgregarTarea(Console.ReadLine());
            MarcarTareaCompletada();
            MostrarEstadoTareas();
        }

        public static void AgregarTarea (string? nombre)
        {
            Tarea tarea = new Tarea(nombre,DateTime.Now);
            tareas.Enqueue(tarea);
        }

        public static void MarcarTareaCompletada ()
        {
            if (tareas.Count > 0)
            {
                tareasCompletadas.Push(tareas.Peek());
                tareas.Dequeue();
            }
            else
                Console.WriteLine("Error: No hay tareas pendientes");
        }

        public static void MostrarEstadoTareas()
        {
            Queue<Tarea> tareasTemp = new Queue<Tarea>(tareas);
            Stack<Tarea> tareasCompletadasTemp = new Stack<Tarea>(tareasCompletadas);

            while (tareasTemp.Count > 0)
            {
                Console.WriteLine(tareasTemp.Peek().ToString() + "\nEstado: Pendiente");
                tareasTemp.Dequeue();
            }
            while(tareasCompletadasTemp.Count > 0)
            {
                Console.WriteLine(tareasCompletadasTemp.Peek().ToString() + "\nEstado: Completada");
                tareasCompletadasTemp.Pop();
            }
        }

    }
}

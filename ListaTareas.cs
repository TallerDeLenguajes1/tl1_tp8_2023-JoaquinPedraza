using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tl1_tp8_2023_JoaquinPedraza
{
    public class ListaTareas
    {
        private List<Tarea> lista = new List<Tarea>();
        private int longitud = 0;

        public List<Tarea> Lista { get => lista; set => lista = value; }
        public int Longitud { get => longitud; set => longitud = value; }

        public void crearTareas()
        {
            Console.WriteLine("Ingrese la cantidad de la tareas que desea añadir: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Tarea tarea = new Tarea();
                tarea.TareaId = longitud+1;
                Console.WriteLine("Ingrese la descripcion de la tarea " +  tarea.TareaId);
                tarea.Descripcion = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion de la tarea " + tarea.TareaId);
                tarea.Duracion = Convert.ToInt32(Console.ReadLine());

                lista.Add(tarea);
                longitud++;
            }
        }

        public Tarea buscarTarea(int tareaId)
        {
            Tarea tareaBuscada = new Tarea();
            tareaBuscada.TareaId = -9999;
            foreach (var item in lista)
            {
                if (item.TareaId == tareaId)
                {
                    tareaBuscada = item;
                    return tareaBuscada;
                }
            }
            return tareaBuscada;
        }

        public bool borrarTarea(int tareaId)
        {
            bool estado = false;
            if (buscarTarea(tareaId).TareaId != -9999) //si existe la tarea
            {
                foreach (var item in lista)
                {
                    if (item.TareaId == tareaId)
                    {
                        estado = true;
                        lista.Remove(item);
                        longitud--;
                        return estado;
                    }
                }
            }
            return estado;
        }

        public void agregarTarea(Tarea tarea)
        {
            lista.Add(tarea);
            longitud++;
        }

        public Tarea buscarTareaPorDesc(string desc)
        {
            Tarea tareaBuscada = new Tarea();
            tareaBuscada.TareaId = -9999;
            foreach (var item in lista)
            {
                if (item.Descripcion == desc)
                {
                    tareaBuscada = item;
                    return tareaBuscada;
                }
            }
            return tareaBuscada;
        }

        public void crearNTareas(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Tarea tarea = new Tarea();
                tarea.TareaId = longitud + 1;
                Console.WriteLine("Ingrese la descripcion de la tarea " + tarea.TareaId);
                tarea.Descripcion = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion de la tarea " + tarea.TareaId);
                tarea.Duracion = Convert.ToInt32(Console.ReadLine());

                lista.Add(tarea);
                longitud++;
            }
        }

        public void listarTareas()
        {

            if (lista.Any())
            {
                foreach (var item in lista)
                {
                    item.mostrarTarea();
                }
            } else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }


    }
}

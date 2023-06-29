using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tl1_tp8_2023_JoaquinPedraza
{
    public class ToDo
    {
        ListaTareas lista1;
        ListaTareas lista2;

        public ListaTareas? Lista1 { get => lista1; set => lista1 = value; }
        public ListaTareas? Lista2 { get => lista2; set => lista2 = value; }

        public ToDo(ListaTareas lista1, ListaTareas lista2)
        {
            this.lista1 = lista1; 
            this.lista2 = lista2;
        }

        public void MoverDeAaB(int idTarea)
        {
            Tarea tarea = lista1.buscarTarea(idTarea);

            if (tarea.TareaId != -9999)
            {

                lista2.agregarTarea(tarea);
                lista1.borrarTarea(tarea.TareaId);
            }
            else
            {
                Console.WriteLine("La tarea que quiere mover no existe");
            }
        }

        public void MoverDeBaA(int idTarea)
        {
            Tarea tarea = lista2.buscarTarea(idTarea);

            if (tarea.TareaId != -9999)
            {

                lista1.agregarTarea(tarea);
                lista2.borrarTarea(tarea.TareaId);
            }
            else
            {
                Console.WriteLine("La tarea que quiere mover no existe");
            }
        }

        public void añadirNTareasEnA(int cantidad)
        {
            lista1.crearNTareas(cantidad);
        }

        public void añadirNTareasEnB(int cantidad)
        {
            lista2.crearNTareas(cantidad);
        }

        public void añadirTareasEnA()
        {
            lista1.crearTareas();
        }

        public void añadirTareasEnB()
        {
            lista2.crearTareas();
        }

        public void listarTareasDeA()
        {
            lista1.listarTareas();
        }

        public void listarTareasDeB()
        {
            lista2.listarTareas();
        }

        public Tarea buscarPorDescEnA(string desc)
        {
            Tarea tarea = lista1.buscarTareaPorDesc(desc);
            if (tarea.TareaId != -9999)
            {
                tarea.mostrarTarea();
            }
            else
            {
                Console.WriteLine("La tarea buscada no se pudo encontrar");
            }
            return tarea;
        }

        public Tarea buscarPorDescEnB(string desc)
        {
            Tarea tarea = lista2.buscarTareaPorDesc(desc);
            if (tarea.TareaId != -9999)
            {
                tarea.mostrarTarea();
            } else
            {
                Console.WriteLine("La tarea buscada no se pudo encontrar");
            }
            return tarea;
        }
    }
}

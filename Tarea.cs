using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tl1_tp8_2023_JoaquinPedraza
{
    public class Tarea
    {
        private int tareaId;
        private string? descripcion;
        private int duracion;

        public int TareaId { get => tareaId; set => tareaId = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public void mostrarTarea()
        {
            Console.WriteLine("/****Tarea " + Convert.ToString(tareaId) + "****/");
            Console.WriteLine("Descripcion: " + descripcion);
            Console.WriteLine("Duracion: " + Convert.ToString(duracion));
        }
    }
}


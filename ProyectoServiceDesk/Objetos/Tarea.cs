using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Tarea
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Prioridad { get; set; }
        public int TiempoHoras { get; set; }
        public int Dificultad { get; set; }
        public Usuario UsuarioAtiende { get; set; }


    }
}

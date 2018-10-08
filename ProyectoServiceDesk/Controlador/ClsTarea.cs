using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsTarea
    {
        public int TareaId { get; set; }
        public string Nombre { get; set; }
        public string Prioridad { get; set; }
        public int TiempoHoras { get; set; }
        public int Dificultad { get; set; }
        public int UsuarioAtiende { get; set; }
        
    }
}

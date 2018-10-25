using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Tarea : Solicitud
    {

        public int NumeroPrioridad { get; set; }
        public string Nombre { get; set; }
        public int TiempoHoras { get; set; }
        public int Dificultad { get; set; }
        public string EstadoProceso { get; set; }
        public Usuario UsuarioAtiende { get; set; }
        public DateTime FechaAtencion { get; set; }

        public Tarea(int numeroIdentificador, string titulo, string tipo, string detalle, string estado, int prioridad, Usuario usuarioIngreso, DateTime fechaIngreso) : base(numeroIdentificador, titulo, tipo, detalle, estado, prioridad, usuarioIngreso, fechaIngreso)
        {
        }





    }
}

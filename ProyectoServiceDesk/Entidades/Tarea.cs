using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Tarea
    {
        public int Id { get; set; }
        public int NumeroPrioridad { get; set; }
        public string Nombre { get; set; }
        public int TiempoHoras { get; set; }
        public int Dificultad { get; set; }
        public string EstadoProceso { get; set; }
        public Usuario UsuarioAtiende { get; set; }
        public DateTime FechaAtencion { get; set; }
        public Solicitud Solicitud { get; set; }

        public Tarea(int id, int numeroPrioridad, string nombre, int tiempoHoras, int dificultad, string estadoProceso, Usuario usuarioAtiende, DateTime fechaAtencion, Solicitud solicitud)
        {
            Id = id;
            NumeroPrioridad = numeroPrioridad;
            Nombre = nombre;
            TiempoHoras = tiempoHoras;
            Dificultad = dificultad;
            EstadoProceso = estadoProceso;
            UsuarioAtiende = usuarioAtiende;
            FechaAtencion = fechaAtencion;
            Solicitud = solicitud;
        }
    }
}

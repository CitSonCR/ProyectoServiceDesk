
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Solicitud
    {
        public int Id { get; set; }
        public int NumeroIdentificador { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public int Prioridad { get; set; }
        public string Solucion { get; set; }
        public Usuario UsuarioIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public List<Tarea> Tareas { get; set; }

        public Solicitud(int numeroIdentificador, string titulo, string tipo, string detalle, string estado, int prioridad, string solucion, Usuario usuarioIngreso, DateTime fechaIngreso)
        {
            NumeroIdentificador = numeroIdentificador;
            Titulo = titulo;
            Tipo = tipo;
            Detalle = detalle;
            Estado = estado;
            Prioridad = prioridad;
            Solucion = solucion;
            UsuarioIngreso = usuarioIngreso;
            FechaIngreso = fechaIngreso;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Solicitud
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        
        public Usuario UsuarioIngresoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Usuario UsuarioAtenconId { get; set; }
        public DateTime FechaAtencion { get; set; }

        public Solicitud(int iD, string titulo, string tipo, string detalle, string estado, string prioridad, Usuario usuarioIngresoId, DateTime fechaIngreso, Usuario usuarioAtenconId, DateTime fechaAtencion)
        {
            ID = iD;
            Titulo = titulo;
            Tipo = tipo;
            Detalle = detalle;
            Estado = estado;
            Prioridad = prioridad;
            UsuarioIngresoId = usuarioIngresoId;
            FechaIngreso = fechaIngreso;
            UsuarioAtenconId = usuarioAtenconId;
            FechaAtencion = fechaAtencion;
        }
    }
}

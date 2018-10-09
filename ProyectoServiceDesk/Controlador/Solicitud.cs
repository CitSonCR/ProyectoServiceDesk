
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsSolicitud
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string Solicitud { get; set; }
        public int UsuarioIngresoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int UsuarioAtenconId { get; set; }
        public DateTime FechaAtencion { get; set; }

        public ClsSolicitud(int solicitudId, string tituloSolicitud, string tipoSolicitud, string detalle, string estado, string prioridad, string solicitud, int usuarioIngresoId, DateTime fechaIngreso, int usuarioAtenconId, DateTime fechaAtencion)
        {
            ID = solicitudId;
            Titulo = tituloSolicitud;
            Tipo = tipoSolicitud;
            Detalle = detalle;
            Estado = estado;
            Prioridad = prioridad;
            Solicitud = solicitud;
            UsuarioIngresoId = usuarioIngresoId;
            FechaIngreso = fechaIngreso;
            UsuarioAtenconId = usuarioAtenconId;
            FechaAtencion = fechaAtencion;
        }
    }
}

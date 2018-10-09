using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsSolicitud
    {
        public int SolicitudId { get; set; }
        public string TituloSolicitud { get; set; }
        public string TipoSolicitud { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string Solicion { get; set; }
        public int UsuarioIngresoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int UsuarioAtenconId { get; set; }
        public DateTime FechaAtencion { get; set; }

        public ClsSolicitud(int solicitudId, string tituloSolicitud, string tipoSolicitud, string detalle, string estado, string prioridad, string solicion, int usuarioIngresoId, DateTime fechaIngreso, int usuarioAtenconId, DateTime fechaAtencion)
        {
            SolicitudId = solicitudId;
            TituloSolicitud = tituloSolicitud;
            TipoSolicitud = tipoSolicitud;
            Detalle = detalle;
            Estado = estado;
            Prioridad = prioridad;
            Solicion = solicion;
            UsuarioIngresoId = usuarioIngresoId;
            FechaIngreso = fechaIngreso;
            UsuarioAtenconId = usuarioAtenconId;
            FechaAtencion = fechaAtencion;
        }
    }
}

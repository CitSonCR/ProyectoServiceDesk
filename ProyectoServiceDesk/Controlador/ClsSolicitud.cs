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
    }
}

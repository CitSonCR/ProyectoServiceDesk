using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk_Controller
{
    public class Solucion
    {
        public String Respuesta { get; set; }
        public String Tipo { get; set; }
        public String AtendidoPor { get; set; }
        public int NumeroConfirmacion { get; set; }
        public DateTime DiaHora { get; set; }
        public String Receptor { get; set; }

        public Solucion(string respuesta, string tipo, string atendidoPor, int numeroConfirmacion, DateTime diaHora, string receptor)
        {
            Respuesta = respuesta;
            Tipo = tipo;
            AtendidoPor = atendidoPor;
            NumeroConfirmacion = numeroConfirmacion;
            DiaHora = diaHora;
            Receptor = receptor;
        }
    }
}

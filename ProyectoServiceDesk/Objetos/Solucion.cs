using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk_Controller
{
    class Solucion
    {
        public String Respuesta { get; set; }
        public String Tipo { get; set; }
        public String Atendidopor { get; set; }
        public int NumeroConfirmacion { get; set; }
        public DateTime DiaHora { get; set; }
        public String Receptor { get; set; }

        public Solucion(string respuesta, string tipo, string atendidopor, int numeroConfirmacion, DateTime diaHora, string receptor)
        {
            Respuesta = respuesta;
            Tipo = tipo;
            Atendidopor = atendidopor;
            NumeroConfirmacion = numeroConfirmacion;
            DiaHora = diaHora;
            Receptor = receptor;
        }
    }
}

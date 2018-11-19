using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk_Controller.Globales
{
    public class Adminstrador_Codigo_Detalle : Adminstrador_Codigo_Maestro
    {
        public string NombreDetalle { get; set; }
        public string Descripcion { get; set; }

        public Adminstrador_Codigo_Detalle()
        {

        }
    }
}

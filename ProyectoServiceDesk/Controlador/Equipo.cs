using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsEquipo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ClsEquipo(string nombreEquipo, string descripcion)
        {
            Nombre = nombreEquipo;
            Descripcion = descripcion;
        }
    }
}

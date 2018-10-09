using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsEquipo
    {
        public int EquipoId { get; set; }
        public string NombreEquipo { get; set; }
        public string Descripcion { get; set; }

        public ClsEquipo(int equipoId, string nombreEquipo, string descripcion)
        {
            EquipoId = equipoId;
            NombreEquipo = nombreEquipo;
            Descripcion = descripcion;
        }
    }
}

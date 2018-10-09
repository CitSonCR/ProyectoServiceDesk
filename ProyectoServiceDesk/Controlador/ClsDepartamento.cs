using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsDepartamento
    {
        public int DepartamentoId { get; set; }
        public string NombreDepartamento { get; set; }
        public string TipoDepartamento { get; set; }
        public string Descripcion { get; set; }

        public ClsDepartamento(int departamentoId, string nombreDepartamento, string tipoDepartamento, string descripcion)
        {
            DepartamentoId = departamentoId;
            NombreDepartamento = nombreDepartamento;
            TipoDepartamento = tipoDepartamento;
            Descripcion = descripcion;
        }
    }
}

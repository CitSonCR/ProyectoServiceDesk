using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class Departamento
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public Departamento(string nombreDepartamento, string tipoDepartamento, string descripcion)
        {
            Nombre = nombreDepartamento;
            Tipo = tipoDepartamento;
            Descripcion = descripcion;
        }
    }
}

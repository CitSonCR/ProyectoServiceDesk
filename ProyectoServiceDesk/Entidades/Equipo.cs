using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ID { get; set; }
        public Departamento Departamento { get; set; }

        public Equipo(string nombre, string descripcion,int id,Departamento departamento)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            ID = id;
            Departamento = departamento;
        }
    }
}

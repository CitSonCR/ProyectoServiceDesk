using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Departamento
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public int ID { get; set; }

        public Departamento(string nombre, string tipo, string descripcion,int id)
        {
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;
            ID = id;
            
            
        }

    }

}


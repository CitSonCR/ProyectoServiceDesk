using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{

    //Esta clase solo manejará los atributos de la entidad Departamento
    public class Departamento
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }

        //Constructor de los atributos 
        public Departamento(string nombre, string tipo, string descripcion)
        {
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;                        
        }

    }

}


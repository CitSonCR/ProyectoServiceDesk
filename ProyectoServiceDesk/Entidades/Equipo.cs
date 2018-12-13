using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    //Esta clase solo manejará los atributos de la entidad Equipo
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }
        //Obtiene atributos de la entidad Departamento
        public Departamento Departamento { get; set; }

        //Constructor de los atributos 
        public Equipo(string nombre, string descripcion,Departamento departamento)
        {
            Nombre = nombre;
            Descripcion = descripcion;            
            Departamento = departamento;
        }
    }
}

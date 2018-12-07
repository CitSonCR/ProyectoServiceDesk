
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk_Controller;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Usuario 
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string TipoUsuario { get; set; }
        public Equipo Equipo { get; set; }
        public Persona Persona { get; set; }
        

        public Usuario(string userName, string password, DateTime fechaIngreso, string tipoUsuario, Equipo equipo, Persona persona)
        {            
            UserName = userName;
            Password = password;
            FechaIngreso = fechaIngreso;
            TipoUsuario = tipoUsuario;
            Equipo = equipo;
            Persona = persona;
        }
    }
}

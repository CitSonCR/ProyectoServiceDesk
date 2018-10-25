
using ProyectoServiceDesk_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Usuario : Persona
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string TipoUsuario { get; set; }
        public Equipo Equipo { get; set; }

        public Usuario(int numeroIdentificacion, string nombre, string primerApellido, string segundoApellido, int edad, string direccion, int telefono, string correoElectronico, string genero, DateTime fechaNacimiento) : base(numeroIdentificacion, nombre, primerApellido, segundoApellido, edad, direccion, telefono, correoElectronico, genero, fechaNacimiento)
        {
        }
    }
}

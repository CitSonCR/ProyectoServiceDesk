using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk_Controller
{
    public class Persona
    {
        protected int NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(int numeroIdentificacion, string nombre, string primerApellido, string segundoApellido, int edad, string direccion, int telefono, string correoElectronico, string genero, DateTime fechaNacimiento)
        {
            NumeroIdentificacion = numeroIdentificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Edad = edad;
            Direccion = direccion;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
        }
    }
}


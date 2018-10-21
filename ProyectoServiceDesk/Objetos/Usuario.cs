
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class Usuario
    {
        public int DepartamentoId { get; set; }
        public int EquipoId { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuario(int departamentoId, int equipoId, string nombre, string primerApellido, string segundoApellido, string email, int telefono, DateTime fechaNacimiento, DateTime fechaIngreso)
        {
            DepartamentoId = departamentoId;
            EquipoId = equipoId;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Email = email;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            FechaIngreso = fechaIngreso;
        }
    }
}

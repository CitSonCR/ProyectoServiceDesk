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
        public string Departamento { get; set; }

        public Equipo(string nombre, string descripcion, string departamento)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Departamento = departamento;
        }

        public void InsertarEquipo()
        {
            String consulta = String.Empty;
            try
            {
                consulta = " INSERT INTO Equipo (                 ";
                consulta += " NOMBRE,                             ";
                consulta += " DESCRIPCIÓN,                        ";
                consulta += " DEPARTAMENTO)                       ";
                consulta += " VALUES(                               ";
                consulta += " '" + Nombre + "',            ";
                consulta += " '" + Descripcion + "',                 ";
                consulta += " '" + Departamento + "',                 ";   
                consulta += " )                                     ";

                return connect.ExecuteQuery(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminarequipo()
        {
            String consulta = String.Empty;
            try
            {
                consulta = " DELETE FROM Equipo WHERE Nombre =  " + Nombre + "   ";

                return connect.ExecuteQuery(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}

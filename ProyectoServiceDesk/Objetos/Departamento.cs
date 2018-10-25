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

        public Departamento(string nombreDepartamento, string tipoDepartamento, string descripcion)
        {
            Nombre = nombreDepartamento;
            Tipo = tipoDepartamento;
            Descripcion = descripcion;
        }


        public void InsertarDepartamento()
        {
            String consulta = String.Empty;
            try { 
            
                consulta = " INSERT INTO Equipo (                 ";
                consulta += " NOMBRE,                             ";
                consulta += " TIPO,                        ";
                consulta += " DESCRIPCION)                       ";
                consulta += " VALUES(                               ";
                consulta += " '" + Nombre + "',            ";
                consulta += " '" + Tipo + "',                 ";
                consulta += " '" + Descripcion + "',                 ";
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Equipo
    {
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private string Departamento { get; set; }

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

        public void ActualizarDatosEquipo()
        {
            String consulta = String.Empty;
            try
            {
                consulta = " UPDATE Departamento                   ";
                consulta += " SET NOMBRE = '" + Nombre + "',    ";
                consulta += " DESCRIPCION = " + Descripcion + ",          ";
                consulta += " DEPARTAMENTO = '" + Departamento + "',        ";
                consulta += " WHERE  NOMBRE =  " + Nombre + "     ";

                return connect.ExecuteQuery(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable CargarEquipo()
        {
            try
            {
                String Consulta = " SELECT NOMBRE AS Name" +
                                   ",DESCRIPCION AS Description" +
                                   ",DEPARTAMENTO AS Department" +
                                   "FROM EQUIPO ";

                return connect.getDatosToDT(Consulta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable CargarGridEquipo(String strWhere)
        {
            try
            {
                String Consulta = "SELECT NOMBRE AS Name ,DESCRIPCION, DEPARTAMENTO, CARGO FROM EQUIPO ";

                if (!String.Empty.Equals(strWhere))
                {
                    Consulta = Consulta + " WHERE " + strWhere;
                }

                return connect.getDatosToDT(Consulta);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
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
            this.Nombre = nombreDepartamento;
            this.Tipo = tipoDepartamento;
            this.Descripcion = descripcion;
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

            public void ActualizarDatosEquipo()
            {
                String consulta = String.Empty;
                try
                {
                    consulta = " UPDATE Departamento                   ";
                    consulta += " SET NOMBRE = '" + Nombre + "',    ";
                    consulta += " TIPO = '" + Tipo + "',        ";
                    consulta += " DESCRIPCION = " + Descripcion + ",          ";
                    consulta += " WHERE  NOMBRE =  " + Nombre + "     ";

                    return connect.ExecuteQuery(consulta);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public DataTable CargarDepartamento()
            {
                try
                {
                    String Consulta = " SELECT NOMBRE AS Name" +
                                       ",TIPO AS Type " +
                                       ",DESCRIPCION AS Description" +
                                       "FROM DEPARTAMENTO ";

                    return connect.getDatosToDT(Consulta);
                }
                catch (Exception)
                {

                    throw;
                }
            }

        public DataTable CargarGridDepartamento(String strWhere)
        {
            try
            {
                String Consulta = "SELECT NOMBRE AS Name,TIPO,DESCRIPCION, CARGO FROM DEPARTAMENTO" +
                    " ";

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

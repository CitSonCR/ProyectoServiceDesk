using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoServiceDesk_Controller;
using ProyectoServiceDesk_View;


namespace ProyectoServiceDesk_Logic
{
    public class LogicaEquipo
    {
        public Boolean IngresarEquipo(string nombre, string descripcion,int id, Departamento departamento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_EQUIPO (NOMBRE, DESCRIPCION,PSD_EQUIPO_ID,PSD_DEPARTAMENTO_NOMBRE) " +
                           " VALUES (@P_NOMBRE,@P_DESCRIPCION,@ID,@P_PSD_DEPARTAMENTO_NOMBRE)";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_DEPARTAMENTO_NOMBRE", departamento.Nombre));




                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarEquipo(string nombre, string descripcion,int id, Departamento departamento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_EQUIPO " +
                            " SET    NOMBRE = @P_NOMBRE," +
                            "        DESCRIPCION = @P_DESCRIPCION, " +
                            "        PSD_DEPARTAMENTO_ID = @P_PSD_DEPARTAMENTO_NOMBRE, " +
                            " WHERE  PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_DEPARTAMENTO_NOMBRE", departamento.Nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", id));



                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarEquipo(int id)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_EQUIPO WHERE PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", GetPsdEquipoIdPorID(id)));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int GetPsdEquipoIdPorID(int id)
        {
            ConexionDB conexion = new ConexionDB();
            int resultado = 0;
            try
            {
                string strSelect = " SELECT PSD_EQUIPO_NOMBRE FROM PSD_EQUIPO WHERE PSD_EQUIPO_ID = @P_ID";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_ID", id));

                resultado = int.Parse(conexion.getDatosBD(strSelect, utils.ParameterCollection).Rows[0][0].ToString());

            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }
    }
}

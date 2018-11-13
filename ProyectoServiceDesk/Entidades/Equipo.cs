using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Equipo : Departamento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Equipo()
        {
        }
        public Equipo(string nombre, string tipo, string descripcion,int Id) : base(nombre, tipo, descripcion,Id)
        {
        }
        public Boolean IngresarEquipo(string nombre, string descripcion,Departamento departamento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_EQUIPO (NOMBRE, DESCRIPCION,PSD_DEPARTAMENTO_ID) " +
                           " VALUES (@P_NOMBRE,@P_DESCRIPCION,@P_PSD_DEPARTAMENTO_ID)";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_DEPARTAMENTO_ID", departamento.GetPsdDepartamentoIdPorNombre(departamento.Nombre)));
                



                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarEquipo(string nombre,string descripcion,Departamento departamento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_EQUIPO " +
                            " SET    NOMBRE = @P_NOMBRE," +
                            "        DESCRIPCION = @P_DESCRIPCION, " +
                            "        PSD_DEPARTAMENTO_ID = @P_PSD_DEPARTAMENTO_ID, " +
                            " WHERE  PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_DEPARTAMENTO_ID", departamento.GetPsdDepartamentoIdPorNombre(departamento.Nombre)));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", GetPsdEquipoIdPorNombre(nombre)));



                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarEquipo(string nombre)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
               strDelete = " DELETE FROM PSD_EQUIPO WHERE PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", GetPsdEquipoIdPorNombre(nombre)));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int GetPsdEquipoIdPorNombre(string nombre)
        {
            ConexionDB conexion = new ConexionDB();
            int resultado = 0;
            try
            {
                string strSelect = " SELECT PSD_EQUIPO_ID FROM PSD_EQUIPO WHERE NOMBRE = @P_NOMBRE";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));

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

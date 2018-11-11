using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
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
        public int DepartamentoID { get; set; }

        public Departamento(string nombre, string tipo, string descripcion,int id)
        {
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;
            DepartamentoID = id;
            
        }

        public Boolean IngresarDepartamento(string nombre, string tipo,string descripcion,int id)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO DEPARTAMENTO(NOMBRE,TIPO,DESCRIPCION,PSD_DEPARTAMENTO_ID) " +
                            " VALUES (@NOMBRE,@TIPO,@DESCRIPCION,@PSD_DEPARTAMENTO_ID)";
                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", tipo));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_DEPARTAMENTO_ID", id));


                conexion.setDatosBD(strInsert, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarDepartamento(string nombre,string tipo,string descripcion,string id)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_DEPARTAMENTO " +
                            " SET    NOMBRE = @NOMBRE," +
                            "        TIPO = @TIPO, " +
                            "        DESCRIPCION = @DESCRIPCION, " +
                            "        PSD_DEPARTAMENTO_ID = @PSD_DEPARTAMENTO, " +
                            " WHERE  NOMBRE = @NOMBRE ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", tipo));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_DEPARTAMENTO_ID",id));


                conexion.setDatosBD(strUpdate, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarPersona(int psdDepartamentoID)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_DEPARTAMENTO WHERE PSD_DEPARTAMENTO_ID = @PSD_DEPARTAMENTO_ID";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_DEPARTAMENTO_ID", psdDepartamentoID));

                conexion.setDatosBD(strDelete, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public int GetPsdDepartamentoIdPorNumeroIdentificador(int id)
        {
            ConexionDB conexion = new ConexionDB();
            int resultado = 0;
            try
            {
                string strSelect = " SELECT * FROM PSD_DEPARTAMENTO WHERE PSD_DEPARTAMENTO_ID = @PSD_DEPARTAMENTO_ID";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_DEPARTAMENTO_ID", id));

                resultado = int.Parse(conexion.getDatosBD(strSelect, utils.parameterCollection).Rows[0][0].ToString());

            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

    }

}


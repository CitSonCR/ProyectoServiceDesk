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

        public Departamento(string nombre, string tipo, string descripcion)
        {
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;
        }

        public Boolean IngresarDepartamento(string nombre, string tipo,string descripcion)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_DEPARTAMENTO (NOMBRE,TIPO,DESCRIPCION) " +
                            " VALUES (@NOMBRE,@APELLIDO1,@APELLIDO2,@TIPO,@DESCRIPCION)";
                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@EDAD", tipo));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DIRECCION", descripcion));


                conexion.setDatosBD(strInsert, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarDepartamento(string nombre,string tipo,string descripcion)
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
                            " WHERE  PSD_DEPARTAMENTO_NOMBRE = @PSD_DEPARTAMENTO_NOMBRE ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@EDAD", tipo));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DIRECCION", descripcion));


                conexion.setDatosBD(strUpdate, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarPersona(int psdDepartamentonombre)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_DEPARTAMENTO WHERE  PSD_DEPARTAMENTO_NOMBRE = @PSD_PERSONA_NOMBRE ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_DEPARTAMENTO", psdDepartamentonombre));

                conexion.setDatosBD(strDelete, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public int GetPsdDepartamentoIdPorNumeroIdentificador(string nombre)
        {
            ConexionDB conexion = new ConexionDB();
            int resultado = 0;
            try
            {
                string strSelect = " SELECT PSD_DEPARTAMENTO_NOMBRE FROM PSD_DEPARTAMENTO WHERE NOMBRE = @NOMBRE ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));

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


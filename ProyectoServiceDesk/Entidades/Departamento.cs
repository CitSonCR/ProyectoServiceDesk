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
       

        public Departamento()
        {
        }

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
                strInsert = "INSERT INTO DEPARTAMENTO(NOMBRE,TIPO,DESCRIPCION) " +
                            " VALUES (@NOMBRE,@TIPO,@DESCRIPCION)";
                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", tipo));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
               
                


                conexion.setDatosBD(strInsert, utils.ParameterCollection);
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
                            " WHERE  DESCRIPCION = @DESCRIPCION ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", tipo));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
                


                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarPersona(string nombre)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_DEPARTAMENTO WHERE PSD_DEPARTAMENTO_ID = @PSD_DEPARTAMENTO_ID";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_DEPARTAMENTO_ID", GetPsdDepartamentoIdPorNombre(nombre)));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public int GetPsdDepartamentoIdPorNombre(string  nombre)
        {
            ConexionDB conexion = new ConexionDB();
            int resultado = 0;
            try
            {
                string strSelect = " SELECT PSD_DEPARTAMENTO_ID FROM PSD_DEPARTAMENTO WHERE NOMBRE = @NOMBRE";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));

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


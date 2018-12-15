using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoServiceDesk_Controller;
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using ProyectoServiceDesk.Controlador;
using System.Windows.Forms;

namespace ProyectoServiceDesk_Controller.LogicaNegocio
{
    public class LogicaUsuario
    {
        public Boolean IngresarUsuario(string userName, string password, string tipoUsuario, Equipo equipo, Persona persona)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_USUARIO (USERNAME, PASSWORD, FECHA_INGRESO, TIPO_USUARIO, PSD_EQUIPO_ID, PSD_PERSONA_ID) " +
                            " VALUES (@P_USERNAME,@P_PASSWORD,GETDATE(),@P_TIPO_USUARIO,@P_PSD_EQUIPO_ID,@P_PSD_PERSONA_ID)";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USERNAME", userName));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PASSWORD", password));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIPO_USUARIO", tipoUsuario));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", equipo.Id));               
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_PERSONA_ID", persona.Id));



                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarUsuario(string userName, string password, DateTime fechaIngreso, string tipoUsuario, Equipo equipo, Persona persona, int psdUsuarioId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            
            try
            {
                strUpdate = " UPDATE PSD_USUARIO " +
                            " SET   USERNAME = @P_USERNAME, " +
                            "       FECHA_INGRESO = @P_FECHA_INGRESO, " +
                            "       TIPO_USUARIO_CODIGO_ID = @P_TIPO_USUARIO_CODIGO_ID, " +
                            "       PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID, " +
                            "       PSD_PERSONA_ID = @P_PSD_PERSONA_ID, " +
                            " WHERE PSD_USUARIO_ID = @P_PSD_USUARIO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USERNAME", userName));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PASSWORD", password));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_FECHA_INGRESO", fechaIngreso));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIPO_USUARIO_CODIGO_ID", tipoUsuario));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", equipo.Id));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_PERSONA_ID", persona.Id));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_USUARIO_ID", psdUsuarioId));


                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarUsuario(int psdUsuarioId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_USUARIO WHERE PSD_USUARIO_ID = @PSD_USUARIO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_USUARIO_ID", psdUsuarioId));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean ValidarUsuario(string userName, string password)
        {
            ConexionDB conexion = new ConexionDB();
            Utils utils = new Utils();
            string resultado = string.Empty;
            string strSelect = string.Empty;
            try
            {
                strSelect = " SELECT CASE WHEN COUNT(0) > 0 THEN 'Y' ELSE 'N' END FROM PSD_USUARIO WHERE USERNAME = @P_USERNAME AND PASSWORD = @P_PASSWORD ";


                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USERNAME", userName));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PASSWORD", password));

                resultado = (conexion.getDatosBD(strSelect, utils.ParameterCollection).Rows[0][0].ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            if (utils.YES.Equals(resultado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidarNombreUsuario(string userName)
        {
            ConexionDB conexion = new ConexionDB();
            Utils utils = new Utils();
            string resultado = string.Empty;
            string strSelect = string.Empty;
            try
            {
                strSelect = " SELECT CASE WHEN COUNT(0) > 0 THEN 'Y' ELSE 'N' END FROM PSD_USUARIO WHERE USERNAME = @P_USERNAME";


                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USERNAME", userName));                

                resultado = (conexion.getDatosBD(strSelect, utils.ParameterCollection).Rows[0][0].ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            if (utils.YES.Equals(resultado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidarCamposRequeridos(Usuario usuario)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario.UserName))
                    return false;
                if (string.IsNullOrEmpty(usuario.Password))
                    return false;
                if (string.IsNullOrEmpty(usuario.TipoUsuario))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(usuario.FechaIngreso)))
                    return false;
                if (null == (usuario.Equipo))
                    return false;
                if (null == (usuario.Persona))
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar la informacion del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }             
            return true;
            
        }

        public Boolean ValidarConfirmacionPassword(string password,string confirmacionPassword)
        {
            if (password.ToUpper().Equals(confirmacionPassword.ToUpper()))
                return true;
            return false;
        }

    }
}

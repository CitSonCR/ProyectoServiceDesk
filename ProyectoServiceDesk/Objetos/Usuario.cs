
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk_Controller;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Usuario : Persona
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string TipoUsuario { get; set; }
        public Equipo Equipo { get; set; }

        public Usuario(int numeroIdentificacion, string nombre, string primerApellido, string segundoApellido, int edad, string direccion, int telefono, string correoElectronico, string genero, DateTime fechaNacimiento) : base(numeroIdentificacion, nombre, primerApellido, segundoApellido, edad, direccion, telefono, correoElectronico, genero, fechaNacimiento)
        {
        }

        public Boolean IngresarUsuario(string userName, string password, DateTime fechaIngreso, string tipoUsuario, Equipo equipo, Persona persona)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_USUARIO (USERNAME, PASSWORD, FECHA_INGRESO, TIPO_USUARIO_CODIGO_ID, PSD_EQUIPO_ID, PSD_PERSONA_ID) " +
                            " VALUES (@P_USERNAME,@P_PASSWORD,@P_FECHA_INGRESO,@P_TIPO_USUARIO_CODIGO_ID,@P_PSD_EQUIPO_ID,@P_PSD_PERSONA_ID)";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USERNAME", userName));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PASSWORD", password));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_FECHA_INGRESO", fechaIngreso));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIPO_USUARIO_CODIGO_ID", tipoUsuario));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", equipo.CodigoEquipo));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_PERSONA_ID", persona.GetPsdPersonaIdPorNumeroIdentificador(persona.NumeroIdentificacion) ));
                


                conexion.setDatosBD(strInsert, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarUsuario(string userName, string password, DateTime fechaIngreso, string tipoUsuario, Equipo equipo, int numeroIdentificacionPersona, int psdUsuarioId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            Persona persona = new Persona();
            try
            {
                strUpdate = " UPDATE PSD_USUARIO " +
                            " SET   USERNAME = @P_USERNAME, " +
                            "       FECHA_INGRESO = @P_FECHA_INGRESO, " +
                            "       TIPO_USUARIO_CODIGO_ID = @P_TIPO_USUARIO_CODIGO_ID, " +
                            "       PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID, " +
                            "       PSD_PERSONA_ID = @P_PSD_PERSONA_ID, " +
                            " WHERE PSD_USUARIO_ID = @P_PSD_USUARIO_ID ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USERNAME", userName));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PASSWORD", password));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_FECHA_INGRESO", fechaIngreso));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIPO_USUARIO_CODIGO_ID", tipoUsuario));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", equipo.CodigoEquipo));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_PERSONA_ID", persona.GetPsdPersonaIdPorNumeroIdentificador(numeroIdentificacionPersona)));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_USUARIO_ID", psdUsuarioId));


                conexion.setDatosBD(strUpdate, utils.parameterCollection);
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

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_USUARIO_ID", psdUsuarioId));

                conexion.setDatosBD(strDelete, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }
    }
}

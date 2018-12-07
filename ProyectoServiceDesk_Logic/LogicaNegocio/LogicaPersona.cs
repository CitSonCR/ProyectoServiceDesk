using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;

namespace ProyectoServiceDesk_Controller.LogicaNegocio
{
    public class LogicaPersona
    {
        public Boolean IngresarPersona(int numeroIdentificacion, string nombre, string primerApellido, string segundoApellido, int edad, string direccion, int telefono, string correoElectronico, string genero, DateTime fechaNacimiento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_PERSONA (NUMERO_IDENTIFICACION, NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, DIRECCION, TELEFONO, CORREO_ELECTRONICO, GENERO, FECHA_NACIMIENTO) " +
                            " VALUES (@IDENTIFICACION,@NOMBRE,@APELLIDO1,@APELLIDO2,@EDAD,@DIRECCION,@TELEFONO,@CORREO,@GENERO,@FECHA_NACIMIENTO)";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@IDENTIFICACION", numeroIdentificacion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@APELLIDO1", primerApellido));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@APELLIDO2", segundoApellido));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@EDAD", edad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DIRECCION", direccion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TELEFONO", telefono));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@CORREO", correoElectronico));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@GENERO", genero));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@FECHA_NACIMIENTO", fechaNacimiento));


                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarPersona(int numeroIdentificacion, string nombre, string primerApellido, string segundoApellido, int edad, string direccion, int telefono, string correoElectronico, string genero, DateTime fechaNacimiento, int psdPersonaId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_PERSONA " +
                            " SET   NUMERO_IDENTIFICACION = @IDENTIFICACION, " +
                            "       NOMBRE = @NOMBRE, " +
                            "       PRIMER_APELLIDO = @APELLIDO1, " +
                            "       SEGUNDO_APELLIDO = @APELLIDO2, " +
                            "       EDAD = @EDAD, " +
                            "       DIRECCION = @DIRECCION, " +
                            "       TELEFONO = @TELEFONO, " +
                            "       CORREO = @CORREO, " +
                            "       GENERO = @GENERO, " +
                            "       FECHA_NACIMIENTO = @FECHA_NACIMIENTO, " +
                            " WHERE  PSD_PERSONA_ID = @PSD_PERSONA_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@IDENTIFICACION", numeroIdentificacion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@APELLIDO1", primerApellido));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@APELLIDO2", segundoApellido));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@EDAD", edad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DIRECCION", direccion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TELEFONO", telefono));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@CORREO", correoElectronico));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@GENERO", genero));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@FECHA_NACIMIENTO", fechaNacimiento));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_PERSONA_ID", psdPersonaId));


                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarPersona(int psdPersonaId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_PERSONA WHERE  PSD_PERSONA_ID = @PSD_PERSONA_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_PERSONA_ID", psdPersonaId));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        //public int GetPsdPersonaIdPorNumeroIdentificador(int numeroIdentificacion)
        //{
        //    ConexionDB conexion = new ConexionDB();
        //    int resultado = 0;
        //    try
        //    {
        //        string strSelect = " SELECT PSD_PERSONA_ID FROM PSD_PERSONA WHERE NUMERO_IDENTIFICACION = @IDENTIFICACION ";

        //        Utils utils = new Utils();
        //        utils.LimpiarSqlParameterCollection();
        //        utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@IDENTIFICACION", numeroIdentificacion));

        //        resultado = int.Parse(conexion.getDatosBD(strSelect, utils.ParameterCollection).Rows[0][0].ToString());

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //    return resultado;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public Boolean ValidarCamposRequeridos(Persona persona)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(persona.NumeroIdentificacion) ))
                    return false;
                if (string.IsNullOrEmpty(persona.Nombre))
                    return false;
                if (string.IsNullOrEmpty(persona.PrimerApellido))
                    return false;
                if (string.IsNullOrEmpty(persona.SegundoApellido))
                    return false;
                if (string.IsNullOrEmpty(persona.Genero))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(persona.Edad)))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(persona.Telefono)))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(persona.FechaNacimiento)))
                    return false;
                if (string.IsNullOrEmpty(persona.CorreoElectronico))
                    return false;
                if (string.IsNullOrEmpty(persona.Direccion))
                    return false;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar la informacion del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return true;
        }


        public Boolean ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // normaliza el dominio
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examina el dominio y lo normaliza
                string DomainMapper(Match match)
                {
                    // Utilice la clase IdnMapping para convertir nombres de dominio Unicode
                    var idn = new IdnMapping();

                    // Extrae y procesa el nombre del dominio
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
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

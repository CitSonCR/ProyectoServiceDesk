using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using ProyectoServiceDesk.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ProyectoServiceDesk_Controller.LogicaNegocio;

namespace ProyectoServiceDesk_Logic
{
    public class LogicaSolicitud
    {
        LogicaUsuario logicaUsuario = new LogicaUsuario();

        public Boolean IngresarSolicitud(int id, int NumeroIdentificador, string Titulo, string Tipo, int Detalle, string Estado, int Prioridad, string Solucion,Usuario UsuarioIngreso, DateTime FechaIngreso,List<Tarea> tareas)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_SOLICITUD ( NUMERO_IDENTIFICADOR, TITULO,TIPO, DETALLE, ESTADO, PRIORIDAD, SOLUCION, PSD_USUARIO_INGRESO, FECHA_INGRESO) " +
                            " VALUES (@ID,@NUMERO_IDENTIFICADOR,@TITULO,@TIPO,@DETALLE,@ESTADO,@PRIORIDAD,@SOLUCION,@PSD_USUARIO_INGRESO,@FECHA_INGRESO)";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();                
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NUMERO_IDENTIFICADOR", NumeroIdentificador));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TITULO", Titulo));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", Tipo));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DETALLE", Detalle));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@ESTADO", Estado));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PRIORIDAD", Prioridad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@SOLUCION", Solucion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_USUARIO_INGRESO", UsuarioIngreso.FechaIngreso));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@FECHA_INGRESO", FechaIngreso));

                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarSolicitud(string Estado, int Prioridad, string Solucion, Usuario UsuarioIngreso, int psdSolicitudId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_SOLICITUD " +
                            " SET   ESTADO = @ESTADO, " +
                            "       PRIORIDAD = @PRIORIDAD, " +
                            "       SOLUCION = @SOLUCION, " +
                            "       USUARIO_INGRESO = @USUARIOINGRESO, " +
                            " WHERE  PSD_SOLICITUD_ID = @PSD_SOLICITUD_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@ESTADO", Estado));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PRIORIDAD", Prioridad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@SOLUCION", Solucion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@USUARIOINGRESO", UsuarioIngreso.FechaIngreso));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_SOLICITUD_ID", psdSolicitudId));

                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarSolicitud(int psdSolicitudId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_SOLICITUD WHERE PSD_SOLICITUD_ID = @PSD_SOLICITUD_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_SOLICITUD_ID", psdSolicitudId));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        //Esta funcion obtiene la informacion de los equipos, lo almacena en un datatable.
        public DataTable ObtenerInfoSolicitud()
        {
            ConexionDB conexion = new ConexionDB();
            DataTable resultado = null;
            try
            {
                string strSelect = " SELECT TITULO,PSD_SOLICITUD_ID FROM PSD_SOLICITUD WHERE ESTADO = 'S'  ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                resultado = (conexion.getDatosBD(strSelect, utils.ParameterCollection));

            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }
        public Solicitud ObtenerInfoCompletaSolicitud(int psdSolicitudId)
        {
            ConexionDB conexion = new ConexionDB();
            DataTable resultado = null;
            Solicitud solicitud = null;
            int Id = 0;
            int NumeroIdentificador = 0;
            string Titulo = string.Empty;
            string Tipo = string.Empty;
            string Detalle = string.Empty;
            string Estado = string.Empty;
            int Prioridad = 0;
            string Solucion = string.Empty;
            Usuario UsuarioIngreso = null;
            DateTime FechaIngreso = DateTime.Now;
            try
            {
                string strSelect = " SELECT PSD_USUARIO.USERNAME,NUMERO_IDENTIFICADOR,TITULO,TIPO,DETALLE,ESTADO,PRIORIDAD,SOLUCION,PSD_SOLICITUD.FECHA_INGRESO,PSD_SOLICITUD.PSD_SOLICITUD_ID FROM PSD_SOLICITUD PSD_SOLICITUD  INNER JOIN PSD_USUARIO PSD_USUARIO ON PSD_SOLICITUD.PSD_USUARIO_INGRESO = PSD_USUARIO.PSD_USUARIO_ID WHERE PSD_SOLICITUD_ID =  @PSD_SOLICITUD_ID ";
                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_SOLICITUD_ID", psdSolicitudId));

              
                resultado = (conexion.getDatosBD(strSelect, utils.ParameterCollection));
                UsuarioIngreso = logicaUsuario.ObtenerInfoUsuario(resultado.Rows[0][0].ToString());
                NumeroIdentificador = Convert.ToInt16(resultado.Rows[0][1].ToString());
                Titulo = resultado.Rows[0][2].ToString();
                Tipo = resultado.Rows[0][3].ToString();
                Detalle = resultado.Rows[0][4].ToString();
                Estado = resultado.Rows[0][5].ToString();
                Prioridad = Convert.ToInt16(resultado.Rows[0][6].ToString());
                Solucion =  resultado.Rows[0][7].ToString();
                FechaIngreso = Convert.ToDateTime(resultado.Rows[0][8].ToString());
                Id = Convert.ToInt16(resultado.Rows[0][9].ToString());

                try
                {
                    solicitud = new Solicitud(psdSolicitudId, NumeroIdentificador, Titulo, Tipo, Detalle, Estado, Prioridad, Solucion, UsuarioIngreso, FechaIngreso, null);
                    solicitud.Id = Id; 
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error al momento de asignar la informacion de la solicitud " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

                throw;
            }


            return solicitud;
        }

        //public void ValidarNombre(KeyPressEventArgs v)
        //{

        //    if (Char.IsLetter(v.KeyChar))
        //    {
        //        v.Handled = false;
        //    }
        //    else if (Char.IsSeparator(v.KeyChar))
        //    {

        //        v.Handled = false;
        //    }
        //    else if (Char.IsControl(v.KeyChar))
        //    {
        //        v.Handled = false;
        //    }
        //    else
        //    {
        //        //Tiramos un mensaje que diga que solo se aceptan letras cuando la variables "v" sea verdadera, que en este caso significa que hay valores diferentes a letras en el textbox
        //        v.Handled = true;
        //        MessageBox.Show("Solo letras por favor. Gracias!");
        //    }

        //}

        public Boolean ValidarFecha(Solicitud solicitud)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(solicitud.FechaIngreso)))
                    return false;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar la informacion del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }             
            return true;
            
        }

    }
}

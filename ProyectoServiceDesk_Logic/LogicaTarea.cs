using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServiceDesk_Logic
{
    public class LogicaTarea
    {
        public Boolean IngresarTarea(int numeroPrioridad, string nombre, int tiempoHoras, int dificultad, string estadoProceso, Usuario usuarioAtiende, DateTime fechaAtencion, Solicitud solicitud)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_TAREA (PSD_SOLICITUD_ID,PSD_USUARIO_ATIENDE_ID,NUMERO_PRIORIDAD, NOMBRE, TIEMPO_HORAS, DIFICULTAD, ESTADO_PROCESO, FECHA_ATENCION) " +
                            " VALUES (@P_PSD_SOLICITUD_ID,@P_PSD_USUARIO_ATIENDE_ID,@P_NUMERO_PRIORIDAD,@P_NOMBRE,@P_TIEMPO_HORAS,@P_DIFICULTAD,@P_ESTADO_PROCESO,GETDATE())";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_SOLICITUD_ID", solicitud.Id));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_USUARIO_ATIENDE_ID", usuarioAtiende.Id));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NUMERO_PRIORIDAD", numeroPrioridad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIEMPO_HORAS", tiempoHoras));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DIFICULTAD", dificultad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_ESTADO_PROCESO", estadoProceso));
                              


                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarTarea(int numeroPrioridad, string nombre, int tiempoHoras, int dificultad, string estadoProceso, Usuario usuarioAtiende, DateTime fechaAtencion, Solicitud solicitud, int psdTareaId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_TAREA " +
                            " SET   NUMERO_PRIORIDAD = @P_NUMERO_PRIORIDAD, " +
                            "       NOMBRE = @P_NOMBRE, " +
                            "       TIEMPO_HORAS = @P_TIEMPO_HORAS, " +
                            "       DIFICULTAD = @P_DIFICULTAD, " +
                            "       ESTADO_PROCESO = @P_ESTADO_PROCESO, " +
                            "       USUARIO_ATIENDE = @P_USUARIO_ATIENDE, " +
                            "       FECHA_ATENCION = @P_FECHA_ATIENDE " +

                            " WHERE  PSD_TAREA_ID = @P_PSD_TAREA_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NUMERO_PRIORIDAD", numeroPrioridad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIEMPO_HORAS", tiempoHoras));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DIFICULTAD", dificultad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_ESTADO_PROCESO", estadoProceso));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USUARIO_ATIENDE", usuarioAtiende.Id));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_FECHA_ATIENDE", fechaAtencion));

                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_TAREA_ID", psdTareaId));

                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarTarea(int psdTareaId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_TAREA WHERE PSD_TAREA_ID = @P_PSD_TAREA_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_TAREA_ID", psdTareaId));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean ValidarCamposRequeridos(Tarea tarea)
        {
            try
            {
                if (string.IsNullOrEmpty(tarea.Nombre))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(tarea.NumeroPrioridad)))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(tarea.TiempoHoras)))
                    return false;
                if (null == tarea.UsuarioAtiende)
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(tarea.Dificultad)))
                    return false;
                if (string.IsNullOrEmpty(tarea.EstadoProceso))
                    return false;
                if (string.IsNullOrEmpty(Convert.ToString(tarea.FechaAtencion)))
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al momento de validar la informacion del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return true;
        }

        //Esta funcion obtiene la informacion de los equipos, lo almacena en un datatable.
        public DataTable ObtenerInfoTareas(int psdSolicitudId)
        {
            ConexionDB conexion = new ConexionDB();
            DataTable resultado = null;
            try
            {
                string strSelect = " SELECT NOMBRE,DIFICULTAD, ESTADO_PROCESO FROM PSD_TAREA WHERE PSD_SOLICITUD_ID = @P_PSD_SOLICITUD_ID  ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_SOLICITUD_ID", psdSolicitudId));
                resultado = (conexion.getDatosBD(strSelect, utils.ParameterCollection));
                

            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }
    }
}

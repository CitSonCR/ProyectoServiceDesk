using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk_Logic
{
    class LogicaTarea
    {
        public Boolean IngresarTarea(int numeroPrioridad, string nombre, int tiempoHoras, int dificultad, string estadoProceso, Usuario usuarioAtiende, DateTime fechaAtencion, Solicitud solicitud)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_TAREA (NUMERO_PRIORIDAD, NOMBRE, TIEMPO_HORAS, DIFICULTAD, ESTADO_PROCESO, USUARIO_ATIENDE, FECHA_ATENCION) " +
                            " VALUES (@P_NUMERO_PRIORIDAD,@P_NOMBRE,@P_TIEMPO_HORAS,@P_DIFICULTAD,@P_ESTADO_PROCESO,@P_USUARIO_ATIENDE,GETDATE())";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NUMERO_PRIORIDAD", numeroPrioridad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_TIEMPO_HORAS", tiempoHoras));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DIFICULTAD", dificultad));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_ESTADO_PROCESO", estadoProceso));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_USUARIO_ATIENDE", usuarioAtiende));                


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
    }
}

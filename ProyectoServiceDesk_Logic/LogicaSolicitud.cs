﻿using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;
using ProyectoServiceDesk.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk_Logic
{
    class LogicaSolicitud
    {
        public Boolean IngresarPersona(int id, int NumeroIdentificador, string Titulo, string Tipo, int Detalle, string Estado, int Prioridad, string Solucion,Usuario UsuarioIngreso, DateTime FechaIngreso,List<Tarea> tareas)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_SOLICITUD (ID, NUMERO_IDENTIFICADOR, TITULO,TIPO, DETALLE, ESTADO, PRIORIDAD, SOLUCION, PSD_USUARIO_INGRESO, FECHA_INGRESO,PSD) " +
                            " VALUES (@ID,@NUMERO_IDENTIFICADOR,@TITULO,@TIPO,@DETALLE,@ESTADO,@PRIORIDAD,@SOLUCION,@PSD_USUARIO_INGRESO,@FECHA_INGRESO)";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@ID", id));
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

        public Boolean EditarPersona(string Estado, int Prioridad, string Solucion, Usuario UsuarioIngreso)
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


                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarPersona(int psdUsuarioId)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_PERSONA WHERE  PSD_USUARIO_ID = @PSD_USUARIO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_PERSONA_ID", psdUsuarioId));

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

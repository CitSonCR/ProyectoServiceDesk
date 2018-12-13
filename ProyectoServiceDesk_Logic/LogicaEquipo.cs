﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Estos ultimos 3 using los necesitamos para obtener datos de clases como Departamento, Equipo, ConexionDB y Utils.
using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk.Utils;




namespace ProyectoServiceDesk_Logic
{
    public class LogicaEquipo
    {
        //Este método ingresa departamentos a la base de datos con los parámetros citados. Instanciamos la clase ConexionDB para la conexion de la base de datos
        public Boolean IngresarEquipo(string nombre, string descripcion, Departamento departamento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_EQUIPO (NOMBRE, DESCRIPCION,PSD_EQUIPO_ID,PSD_DEPARTAMENTO_ID) " +
                           " VALUES (@P_NOMBRE,@P_DESCRIPCION,@ID,@P_PSD_DEPARTAMENTO_NOMBRE)";

                Utils utils = new Utils();
                //Con el utils limpiamos la base de cualquier parametro que ingrese datos 
                utils.LimpiarSqlParameterCollection();
                //Aqui ingresamos datos con la funcion Add en la base de datos
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_DEPARTAMENTO_NOMBRE", departamento.Id));




                //Aqui seteamos esos datos 
                conexion.setDatosBD(strInsert, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        //Aqui el concepto es el mismo que en la insercion de la informacion en la base de datos, solo que esta editara el dato que queramos dependiendo del ID del departamento 
        public Boolean EditarEquipo(string nombre, string descripcion,int id, Departamento departamento)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_EQUIPO " +
                            " SET    NOMBRE = @P_NOMBRE," +
                            "        DESCRIPCION = @P_DESCRIPCION, " +
                            "        PSD_DEPARTAMENTO_ID = @P_PSD_DEPARTAMENTO_NOMBRE, " +
                            " WHERE  PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_DEPARTAMENTO_NOMBRE", departamento.Nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", id));



                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        //Aqui el concepto es el mismo que en la insercion de la informacion en la base de datos, solo que esta eliminará el dato que queramos dependiendo del ID del departamento
        public Boolean EliminarEquipo(int id)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
                strDelete = " DELETE FROM PSD_EQUIPO WHERE PSD_EQUIPO_ID = @P_PSD_EQUIPO_ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_PSD_EQUIPO_ID", GetPsdEquipoIdPorID(id)));

                conexion.setDatosBD(strDelete, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }


        //Aqui el concepto es el mismo que en la insercion de la informacion en la base de datos, solo que esta obtendrá el dato que queramos dependiendo del ID del departamento //Aqui el concepto es el mismo que en la insercion de la informacion en la base de datos, solo que esta obtendrá el dato que queramos dependiendo del ID del departamento.
        public int GetPsdEquipoIdPorID(int id)
        {
            ConexionDB conexion = new ConexionDB();
            int resultado = 0;
            try
            {
                string strSelect = " SELECT PSD_EQUIPO_NOMBRE FROM PSD_EQUIPO WHERE PSD_EQUIPO_ID = @P_ID";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@P_ID", id));

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

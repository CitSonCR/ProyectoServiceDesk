﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Estos ultimos 3 using los necesitamos para obtener datos de clases como Departamento, Equipo, ConexionDB y Utils.
using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk.Utils;
using ProyectoServiceDesk.Modelo;
using System.Windows.Forms;
using System.Data;

namespace ProyectoServiceDesk_Logic
{
    public class LogicaDepartamento
    {
        //Este método ingresa departamentos a la base de datos con los parámetros citados.Instanciamos la clase ConexionDB para la conexion de la base de datos 
        public Boolean IngresarDepartamento(string nombre, string tipo, string descripcion)
        {
            
            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_DEPARTAMENTO(NOMBRE,TIPO,DESCRIPCION) " +
                            " VALUES (@NOMBRE,@TIPO,@DESCRIPCION)";
                //Con el utils limpiamos la base de cualquier parametro que ingrese datos 
                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                //Aqui ingresamos datos con la funcion Add en la base de datos
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", tipo));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));



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
        public Boolean EditarDepartamento(string nombre, string tipo, string descripcion,int id)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_DEPARTAMENTO " +
                            " SET    NOMBRE = @NOMBRE," +
                            "        TIPO = @TIPO, " +
                            "        DESCRIPCION = @DESCRIPCION," +
                            " WHERE  PSD_DEPARTAMENTO_ID = @ID ";

                Utils utils = new Utils();
                utils.LimpiarSqlParameterCollection();
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@TIPO", tipo));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
                utils.ParameterCollection.Add(new System.Data.SqlClient.SqlParameter("@ID", descripcion));


                conexion.setDatosBD(strUpdate, utils.ParameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        
        //Este metodo obtiene los datos de Departamentos y los aloja en un datatable propiedad de la libreria data
        public DataTable ObtenerInfoDepartamentos()
        {
            //se hace la conexion con la BD
            ConexionDB conexion = new ConexionDB();
            DataTable resultado = null;
            try
            {
                string strSelect = " SELECT NOMBRE,PSD_DEPARTAMENTO_ID FROM PSD_DEPARTAMENTO ";

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

        /

    }


}


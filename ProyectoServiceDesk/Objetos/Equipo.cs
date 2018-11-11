using ProyectoServiceDesk.Modelo;
using ProyectoServiceDesk_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    public class Equipo : Departamento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CodigoEquipo { get; set; }
        public Departamento departamento { get; set; }

        public Equipo(string nombre, string descripcion, string tipo,int id) :base(nombre, tipo, descripcion,id)
        {
        }

        public Boolean IngresarEquipo(string nombre, string descripcion,Departamento departamento, string codigoequipo)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strInsert = string.Empty;
            try
            {
                strInsert = "INSERT INTO PSD_EQUIPO (NOMBRE, DESCRIPCION,DEPARTAMENTO,PSD_EQUIPO_ID) " +
                           " VALUES (@NOMBRE,@DESCRIPCION,@DEPARTAMENTO,@PSD_EQUIPO_ID)";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DEPARTAMENTO", GetPsdDepartamentoIdPorNumeroIdentificador(departamento.Nombre)));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_EQUIPO_ID", codigoequipo));



                conexion.setDatosBD(strInsert, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EditarEquipo(string nombre,string descripcion,Departamento departamento, string codigoequipo)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strUpdate = string.Empty;
            try
            {
                strUpdate = " UPDATE PSD_EQUIPO " +
                            " SET    NOMBRE = @NOMBRE," +
                            "        DESCRIPCION = @DESCRIPCION, " +
                            "        PSD_EQUIPO_ID = @PSD_EQUIPO_ID, " +
                            " WHERE  NOMBRE = @NOMBRE ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@NOMBRE", nombre));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPCION", descripcion));
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_EQUIPO_ID", codigoequipo));



                conexion.setDatosBD(strUpdate, utils.parameterCollection);
            }
            catch (Exception)
            {

                throw;
            }


            return resultado;
        }

        public Boolean EliminarEquipo(int psdEquipoid)
        {

            ConexionDB conexion = new ConexionDB();
            bool resultado = true;
            string strDelete = string.Empty;
            try
            {
               strDelete = " DELETE FROM PSD_EQUIPO WHERE PSD_EQUIPO_ID = @PSD_EQUIPO_ID ";

                Utils.Utils utils = new Utils.Utils();
                utils.LimpiarSqlParameterCollection();
                utils.parameterCollection.Add(new System.Data.SqlClient.SqlParameter("@PSD_EQUIPO_ID", psdEquipoid));

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

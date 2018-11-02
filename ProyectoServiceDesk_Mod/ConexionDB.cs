using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoServiceDesk.Modelo
{
    public class ConexionDB
    {
        public SqlConnection conexion = new SqlConnection();

        public SqlConnection ObtenerConexion()
        {
            conexion = new SqlConnection("Server = tcp:analisis.database.windows.net,1433; Initial Catalog = SERVICE_DESK; Persist Security Info = False; User ID = AnalisisSabados; Password = Analisis2018; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");           
            //Server=tcp:analisis.database.windows.net,1433;Initial Catalog=AnalisisDataBase;Persist Security Info=False;User ID=AnalisisSabados;Password=Analisis2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                throw;
            }
        }

        public DataTable getDatosBD(String strSQL, SqlParameterCollection ListaParametros)
        {
            DataTable dtDatos = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ObtenerConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                if (ListaParametros != null)
                {
                    foreach (var item in ListaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dtDatos);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar sentencia: " + ex.Message);

            }
            finally
            {
                conexion.Close();
            }
            return dtDatos;
        }

        public String setDatosBD(String strSQL, SqlParameterCollection ListaParametros)
        {
            String bandera = String.Empty;
            try
            {
                ObtenerConexion();
                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                if (ListaParametros != null)
                {
                    foreach (var item in ListaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.ExecuteNonQuery();
                bandera = "Proceso correcto";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar sentencia: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return bandera;
        }


        //public Boolean Desconectar()
        //{
        //    Boolean desconectar = false;
        //    try
        //    {

        //        if (conexion.State.Equals(ConnectionState.Open))
        //        {
        //            conexion.Close();
        //            desconectar = true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        desconectar = false;

        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //    return desconectar;
        //}

        //public SqlDataReader getDataReader(String strSQL)
        //{
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = strSQL;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = ObtenerConexion();
        //        return cmd.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Error al ejecutar sentencia: " + ex.Message);
        //        return null;
        //    }
        //    finally
        //    {
        //        //conexion.Close();
        //    }
        //}

    }
}

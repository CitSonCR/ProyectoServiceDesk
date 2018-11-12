using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Utils
{
    public class Utils
    {
        public List<SqlParameter> ParameterCollection = new List<SqlParameter>();
        public string YES = "Y";
        public string NO = "N";

        public void LimpiarSqlParameterCollection()
        {
            if (null != ParameterCollection)
                ParameterCollection.Clear();
        } 



    }
}

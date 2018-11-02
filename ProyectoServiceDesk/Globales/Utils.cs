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
        public SqlParameterCollection parameterCollection { get; set; }

        public void LimpiarSqlParameterCollection()
        {
            parameterCollection.Clear();
        }



    }
}

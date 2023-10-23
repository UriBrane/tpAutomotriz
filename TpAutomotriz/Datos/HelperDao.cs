using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotriz.Datos
{
    public class HelperDao
    {        
        private static HelperDao instance;
        private SqlConnection cnn;

        private HelperDao()
        {
            cnn = new SqlConnection(Properties.Resources.CadenaConexion1);
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public SqlConnection GetSqlConnection()
        {
            return this.cnn;
        }

        public DataTable ConsultarSp(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

    }
}

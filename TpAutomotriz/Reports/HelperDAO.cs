using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class HelperDAO
    {
        private static HelperDAO instance;
        private SqlConnection cnn;
        private HelperDAO()
        {
            cnn = new SqlConnection(Properties.Resources.String1);
        }

        public static HelperDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDAO();
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

        public DataTable ConsultarTabla(string nombreSP, List<Parametro> lp)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (Parametro p in lp)
            {
                cmd.Parameters.AddWithValue(p.Clave, p.Valor);
            }
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

    }
}

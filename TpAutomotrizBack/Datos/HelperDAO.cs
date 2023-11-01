using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpAutomotrizBack.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instance;
        private SqlConnection cnn;

        private HelperDAO()
        {
            cnn = new SqlConnection(Properties.Resources.CadenaConexionAndres);
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
        {// Consultar una tabla de la BD con el nombre de un SP
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public int EjecutarSQL(string strSql, List<Parametro> lParametros)
        {// Ejecuta un SP con una lista de Parametros
            int filasAfectadas = 0;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(strSql, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lParametros != null)
                {
                    foreach (Parametro p in lParametros)
                    {
                        cmd.Parameters.AddWithValue(p.Clave, p.Valor);
                    }
                }

                filasAfectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException ex)
            {
                if (t != null) { t.Rollback(); }
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return filasAfectadas;
        }

        public int EjecutarSQL(string spMaestro, string spDetalle, List<Parametro> lParamMaestro, List<Parametro> lParamDetalle)
        {// Ejecuta una transaccion Maestro-Detalle con los nombres de los sp como param de entrada y las listas de parametros, devuelve el numero de factura
            int nroFactura = 0;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdMaestro = new SqlCommand(spMaestro, cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                if (lParamMaestro != null)
                {
                    foreach (Parametro p in lParamMaestro)
                    {
                        cmdMaestro.Parameters.AddWithValue(p.Clave, p.Valor);
                    }
                }

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);

                cmdMaestro.ExecuteNonQuery();

                nroFactura = Convert.ToInt32(param.Value);

                cmdMaestro.ExecuteNonQuery();

                int detallleNro = 1;

                SqlCommand cmdDetalle;
                if (lParamDetalle != null)
                {
                    foreach (Parametro p in lParamDetalle)
                    {
                        cmdDetalle = new SqlCommand(spDetalle, cnn, t);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;

                        cmdDetalle.Parameters.AddWithValue(p.Clave, p.Valor);

                        cmdDetalle.Parameters.AddWithValue("@nro_fac", nroFactura);
                        cmdDetalle.Parameters.AddWithValue("@detalle", detallleNro);

                        cmdDetalle.ExecuteNonQuery();

                        detallleNro++;
                    }
                }

                t.Commit();
            }
            catch (SqlException ex)
            {
                if (t != null) { t.Rollback(); }
                MessageBox.Show("Error: "+ ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return nroFactura;
        }

    }
}

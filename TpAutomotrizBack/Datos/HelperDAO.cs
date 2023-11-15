using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Datos
{
    public class HelperDAO
    {
        private static HelperDAO? instance;
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

        public DataTable ConsultarTabla(string nombreSP, string nomParam, int id)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(nomParam, id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable ConsultarTabla(string nombreSP)
        {// Consultar una tabla de la BD con el nombre de un SP
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public bool EjecutarSQL(string strSql, List<Parametro> lParametros)
        {// Ejecuta un SP con una lista de Parametros
            int filasAfectadas = 0;
            SqlTransaction? t = null;

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
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool EjecutarSQL(string spMaestro, string spDetalle, List<Parametro> lParamMaestro, List<List<Parametro>> lParamDetalle)
        {// Ejecuta una transaccion Maestro-Detalle con los nombres de los sp como param de entrada y las listas de parametros, devuelve el numero de factura
            int nroFactura = 0;
            SqlTransaction? t = null;

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

                //int detallleNro = 1;
                SqlCommand cmdDetalle;

                if (lParamDetalle != null)
                {
                    foreach (List<Parametro> l in lParamDetalle)
                    {
                        foreach (Parametro p in l)
                        {
                            cmdDetalle = new SqlCommand(spDetalle, cnn, t);
                            cmdDetalle.CommandType = CommandType.StoredProcedure;

                            cmdDetalle.Parameters.AddWithValue(p.Clave, p.Valor);

                            cmdDetalle.Parameters.AddWithValue("@nro_fac", nroFactura);
                            //cmdDetalle.Parameters.AddWithValue("@detalle", detallleNro);

                            cmdDetalle.ExecuteNonQuery();

                            //detallleNro++;
                        }
                    }
                }

                t.Commit();
            }
            catch
            {
                if (t != null) { t.Rollback(); }
                return false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return true;
        }

        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand(nombreSP,cnn);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParamOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            cnn.Close();

            return (int)parametro.Value;
        }
    }
}

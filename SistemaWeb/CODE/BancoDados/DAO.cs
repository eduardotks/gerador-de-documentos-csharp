using SistemaWeb.CODE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SistemaWeb.CODE
{
    public class DAO
    {
        public DbConnection getConnection(ConnectionString connString)
        {
            DbProviderFactory dbFactory = MySqlClientFactory.Instance;
            DbConnection dbConn = dbFactory.CreateConnection();
            dbConn.ConnectionString = connString.ConnString;
            dbConn.Open();
            return dbConn;
        }
        public DbCommand getCommand(ConnectionString connString)
        {
            DbProviderFactory dbFactory = MySqlClientFactory.Instance;
            DbCommand dbCmd = dbFactory.CreateCommand();
            dbCmd.Connection = getConnection(connString);
            dbCmd.CommandType = CommandType.Text;
            dbCmd.CommandTimeout = 0;
            return dbCmd;
        }
        public DataTable getData(ConnectionString connString, string CommandText)
        {
            DataTable dt = new DataTable();
            ConnectionString connectionString = new ConnectionString("");
            using (MySqlConnection conn = new MySqlConnection(connectionString.ConnString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(CommandText, conn);
                DbDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                    dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                while (reader.Read())
                {
                    var linha = dt.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                        linha[reader.GetName(i)] = reader.GetValue(i);
                    dt.Rows.Add(linha);
                }
                return dt;
            }
        }
        public int Execute(DbCommandGeneric dbCmd)
        {
            int rowsAffected = -1;
            try
            {
                string commandTextTemp = dbCmd.DbCommand.CommandText;
                List<DbParameter> parametersTemp = new List<DbParameter>();
                foreach (DbParameter parametro in dbCmd.DbCommand.Parameters)
                    parametersTemp.Add(parametro);
                dbCmd.DbCommand.CommandText = commandTextTemp;
                dbCmd.DbCommand.Parameters.Clear();
                foreach (DbParameter parametro in parametersTemp)
                    dbCmd.DbCommand.Parameters.Add(parametro);
                rowsAffected = dbCmd.DbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
                throw ex;
            }
            finally
            {
                if (Connection.DbCommand == null)
                    dbCmd.DbCommand.Connection.Close();
            }
            return rowsAffected;
        }
        public int Execute_ReturnID(ConnectionString connString, DbCommandGeneric dbCmd)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = new MySqlConnection(connString.ConnString);
                cmd.Connection.Open();
                cmd.CommandText = dbCmd.DbCommand.CommandText;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    return Convert.ToInt32(cmd.LastInsertedId);
                else
                    return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public Object ExecuteScalar(DbCommandGeneric dbCmd)
        {
            Object obj;
            try
            {
                obj = dbCmd.DbCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            if (Connection.DbCommand == null)
                dbCmd.DbCommand.Connection.Close();
            return obj;
        }
    }
}

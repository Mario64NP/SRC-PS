using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Aplikacija.Repozitorijum
{
    public class DbConnection
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public void OpenConnection()
        {
            if (!IsReady())
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SRC"].ConnectionString);
                connection.Open();
            }
        }

        public SqlCommand CreateCommand(string cmd = "")
        {
            if (transaction is null)
                transaction = connection.BeginTransaction();

            return new SqlCommand(cmd, connection, transaction);
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction?.Rollback();
        }
        public bool IsReady()
        {
            return connection != null && connection.State != ConnectionState.Closed;
        }
        public void Close()
        {
            connection?.Close();
            transaction?.Dispose();
            transaction = null;
        }
    }
}
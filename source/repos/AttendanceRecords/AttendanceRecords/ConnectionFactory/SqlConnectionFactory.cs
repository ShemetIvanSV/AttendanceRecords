using System.Data;
using System.Data.SqlClient;

namespace AttendanceRecords.ConnectionFactory
{
    public class SqlConnectionFactory : IConnectionFactory
    {
        public IDbConnection Create(string connectionString)
        {
            var connection = new SqlConnection(connectionString);

            connection.Open();

            return connection;
        }
    }
}

using System.Data;

namespace AttendanceRecords.ConnectionFactory
{
    public interface IConnectionFactory
    {
        IDbConnection Create(string connectionString);
    }
}

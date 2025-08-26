using Microsoft.Data.Sqlite;

namespace Demo.Data
{
    public interface IDbConnectionFactory
    {
        SqliteConnection CreateConnection();
    }

    public class InMemorySqliteConnectionFactory : IDbConnectionFactory
    {
        private readonly SqliteConnection _connection;

        public InMemorySqliteConnectionFactory(SqliteConnection connection)
        {
            _connection = connection;
        }

        public SqliteConnection CreateConnection()
        {
            return _connection;
        }
    }
}

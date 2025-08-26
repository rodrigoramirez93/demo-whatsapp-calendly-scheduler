using Dapper;
using Demo.Data.Domain;

namespace Demo.Data
{
    public interface IConversationRepository
    {
        Task EnsureConversationTableExistsAsync();
        Task<IEnumerable<Conversation>> GetAllConversationsAsync();
        Task CreateConversationAsync(Guid id, string from, string to, int? messageId = null);
    }

    public class ConversationRepository : IConversationRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public ConversationRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task EnsureConversationTableExistsAsync()
        {
            var connection = _connectionFactory.CreateConnection();

            const string createTableSql = @"
            CREATE TABLE IF NOT EXISTS Conversations (
                Id TEXT PRIMARY KEY,
                MessageId INTEGER NULL,
                CreatedAt TEXT NULL,
                [From] TEXT NULL,
                [To] TEXT NULL
            );";

            await connection.ExecuteAsync(createTableSql);
        }

        public async Task<IEnumerable<Conversation>> GetAllConversationsAsync()
        {
            var connection = _connectionFactory.CreateConnection();
            const string sql = "SELECT Id, MessageId, CreatedAt, [From], [To] FROM Conversations;";
            return await connection.QueryAsync<Conversation>(sql);
        }

        public async Task CreateConversationAsync(Guid id, string from, string to, int? messageId)
        {
            var connection = _connectionFactory.CreateConnection();

            const string sql = @"
                INSERT INTO Conversations (Id, MessageId, CreatedAt, [From], [To])
                VALUES (@Id, @MessageId, @CreatedAt, @From, @To);";

            await connection.ExecuteAsync(sql, new
            {
                Id = id.ToString(),
                MessageId = messageId,
                CreatedAt = DateTimeOffset.UtcNow,
                From = from,
                To = to
            });
        }
    }
}
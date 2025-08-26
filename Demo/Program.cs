using Demo.Business;
using Demo.Data;
using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton(provider =>
{
    var connection = new SqliteConnection("Data Source=:memory:");
    connection.Open();
    return connection;
});
builder.Services.AddSingleton<IDbConnectionFactory, InMemorySqliteConnectionFactory>();
builder.Services.AddScoped<IConversationRepository, ConversationRepository>();
builder.Services.AddScoped<Engine>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var conversationRepository = scope.ServiceProvider.GetRequiredService<IConversationRepository>();
    await conversationRepository.EnsureConversationTableExistsAsync();
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

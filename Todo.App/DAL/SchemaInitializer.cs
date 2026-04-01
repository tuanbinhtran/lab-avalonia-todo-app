using System.Data.Common;
using System.Threading.Tasks;
using Dapper;
using DuckDB.NET.Data;

namespace Todo.App.DAL;

public static class SchemaInitializer
{
    public static async Task InitializeAsync(DuckDBConnection connection)
    {
        await connection.OpenAsync();
        using var transaction = await connection.BeginTransactionAsync();
        
        // Create tables
        await CreateTodoItemsTableAsync(connection);


        await transaction.CommitAsync();
    }

    private static async Task CreateTodoItemsTableAsync(DbConnection connection) 
        => await connection.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS TodoItems (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                IsCompleted BOOLEAN NOT NULL
            );
        ");
}
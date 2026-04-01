using System.Data.Common;
using DuckDB.NET.Data;

namespace Todo.App.DAL;

public class DbConnectionFactory(string connectionString)
{
    private readonly string _connectionString = connectionString;

    public DbConnection CreateConnection()
    {
        return new DuckDBConnection(_connectionString);
    }
}
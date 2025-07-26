using Dapper;
using Npgsql;
using summa_backend.Models;

namespace summa_backend.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IConfiguration _config;

    public UserRepository(IConfiguration config)
    {
        _config = config;
    }

    public User? GetByUsernameAndPassword(string username, string password)
    {
        using var conn = new NpgsqlConnection(_config.GetConnectionString("DefaultConnection"));
        var sql = "SELECT * FROM users WHERE username = @Username AND password = @Password";
        return conn.QueryFirstOrDefault<User>(sql, new { Username = username, Password = password });
    }
}
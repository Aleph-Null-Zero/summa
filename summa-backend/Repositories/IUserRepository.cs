using summa_backend.Models;

namespace summa_backend.Repositories;

public interface IUserRepository
{
    User? GetByUsernameAndPassword(string username, string password);
}
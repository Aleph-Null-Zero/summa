namespace summa_backend.Services;

public interface IAuthService
{
    string Authenticate(string username, string password);
}
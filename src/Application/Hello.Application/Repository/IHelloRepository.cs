using Hello.Domain;

namespace Hello.Application.Repository
{
    public interface IHelloRepository
    {
        Task<User?> GetUser(int userId);
    }
}
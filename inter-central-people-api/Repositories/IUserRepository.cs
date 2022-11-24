using Models;

namespace Repositories
{
    public interface IUserRepository
    {
        Task<UserDBO?> GetFirstUser(string Bi);
    }
}

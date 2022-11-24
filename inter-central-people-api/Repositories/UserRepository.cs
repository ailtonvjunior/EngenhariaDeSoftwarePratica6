using Context;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PeopleCentralContext _context;

        public UserRepository(PeopleCentralContext context)
        {
            _context = context;
        }


        public async Task<UserDBO?> GetFirstUser(string Bi)
        {
            var user = await this._context.Users.Where(user => user.Bi == Bi).SingleOrDefaultAsync();

            return user;
        }
    }
}

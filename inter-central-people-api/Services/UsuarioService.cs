using Models;
using Repositories;

namespace Services

{
    public class UsuarioService : IUsuarioService
    {
       
        private readonly IUserRepository _repository;

        public UsuarioService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserDBO> GetUserDBO(string Bi)
        {
            var user = await _repository.GetFirstUser(Bi);
            return user;

        }
    }
}

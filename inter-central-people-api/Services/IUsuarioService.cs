using Models;

namespace Services

{
    public interface IUsuarioService
    {
        Task<UserDBO> GetUserDBO(string Bi);
    }
}

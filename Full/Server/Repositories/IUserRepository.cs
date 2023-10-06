using Full.Server.DTO;
using Full.Shared;

namespace Full.Server.Repositories
{
    public interface IUserRepository
    {

        Task<User> AddUserAsync(UserDTO userDTO);
        Task<User> Login(LoginDTO loginDTO);

    }
}

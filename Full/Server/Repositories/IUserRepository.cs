using Microsoft.AspNetCore.Identity;

namespace Full.Server.Repositories
{
    public interface IUserRepository<User>
    where User : IdentityUser
    {
        Task<IdentityResult> CreateUserAsync(User user, string password);
        Task<User> FindUserByIdAsync(string userId);
        Task<User> FindUserByEmailAsync(string email);
        Task<List<User>> GetAllUsersAsync();
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<IdentityResult> DeleteUserAsync(User user);
        Task<bool> UserExistsAsync(string email);
    }
}

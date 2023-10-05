using AutoMapper;
using Full.Server.Data;
using Full.Server.DTO;
using Full.Server.Repositories;
using Full.Shared;

namespace Full.Server.Services
{
    public class UserService : IUserRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public UserService(AppDbContext appDbContext, IMapper mapper)
        {
            _context = appDbContext;
            _mapper = mapper;
        }


        public async Task<User> AddUserAsync(UserDTO userDTO)
        {
            User user = new User();
            user.FullName = userDTO.FullName;
            user.Email = userDTO.Email;
            user.Password = userDTO.Password;

            // User user = _mapper.Map<User>(userDTO);

            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}

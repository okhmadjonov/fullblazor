using AutoMapper;
using Full.Server.Data;
using Full.Server.DTO;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

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

        public Task<User> Login(LoginDTO loginDTO)
        {
            var user = _context.User.FirstOrDefaultAsync(u => u.Email == loginDTO.Email && u.Password == loginDTO.Password);
            return user;
        }
    }
}

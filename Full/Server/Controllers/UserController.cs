//using Full.Client.DTO;
using Full.Server.DTO;
using Full.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Full.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDTO userDTO)
        {
            return Ok(await _userRepository.AddUserAsync(userDTO));
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var checkUser = await _userRepository.Login(loginDTO);
            if (checkUser == null)
            {
                return BadRequest("Incorrect Email or Password");
            }
            return Ok(checkUser);

        }
    }
}

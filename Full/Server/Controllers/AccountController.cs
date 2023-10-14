//using Full.Client.DTO;
using AutoMapper;
using Full.Server.DTO;
using Full.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Full.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {


        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }




        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {


            if (!ModelState.IsValid) return Ok(loginDTO);

            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user != null)
            {
                //User is found, check password
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
                if (passwordCheck)
                {

                    var result = await _signInManager.PasswordSignInAsync(user, loginDTO.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Ok(result);
                    }
                }
                //Password is incorrect 

                return Ok(loginDTO);
            }

            // User not found

            return Ok(loginDTO);
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserDTO userDTO)
        {
            if (!ModelState.IsValid) return Ok(userDTO);
            Console.Write("You entered this Email: " + userDTO.Email + "\n" + " And Password is " + userDTO.Password);
            var user = await _userManager.FindByEmailAsync(userDTO.Email);
            if (user != null)
            {
                return Ok(userDTO);
            }

            var newUser = new User()
            {
                Fullname = userDTO.Fullname,
                Email = userDTO.Email,

            };
            var newUserResponse = await _userManager.CreateAsync(newUser, userDTO.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            await _userManager.CreateAsync(newUser);

            return Ok(newUser);
        }

    }
}

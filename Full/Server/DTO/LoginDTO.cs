using System.ComponentModel.DataAnnotations;

namespace Full.Server.DTO
{
    public class LoginDTO
    {

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}

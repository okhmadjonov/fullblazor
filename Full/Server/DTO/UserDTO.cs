using System.ComponentModel.DataAnnotations;

namespace Full.Server.DTO
{
    public class UserDTO
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Fullname is required")]
        public required string Fullname { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

    }
}

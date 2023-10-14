using Microsoft.AspNetCore.Identity;

namespace Full.Shared
{
    public class User : IdentityUser
    {

        public int Id { get; set; }

        public required string Fullname { get; set; }

        public List<Course>? Courses { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace IdentityDemo_1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}

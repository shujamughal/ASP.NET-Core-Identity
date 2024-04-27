using Microsoft.AspNetCore.Identity;
using NuGet.ProjectModel;
using System.ComponentModel.DataAnnotations;

namespace Lec2_aspnet_core_identity_customization.Data
{
    public class MyAppUser :IdentityUser
    {
        [Required]
        public string? City { get; set; }
        [Required]
        public string? Country { get; set; }
        
    }
}

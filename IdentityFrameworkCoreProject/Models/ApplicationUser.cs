using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityFrameworkCoreProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        [ValidateNever]
        public string ProfilePicPath { get; set; }
        [NotMapped]
        public IFormFile ProfilePic { get; set; }
    }
}

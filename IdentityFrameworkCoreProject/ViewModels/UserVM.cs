using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityFrameworkCoreProject.ViewModels
{
    public class UserVM 
    {
        public string FullName { get; set; }
        [NotMapped]
        public IFormFile ProfilePic { get; set; }
    }
}

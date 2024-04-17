using IdentityFrameworkCoreProject.Models;
using IdentityFrameworkCoreProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityFrameworkCoreProject.Controllers
{
    public class UserInfoController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        public UserInfoController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var alluser = _userManager.Users.ToList();
            return View(alluser);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserVM user)
        {
            return View(user);
        }
    }
}

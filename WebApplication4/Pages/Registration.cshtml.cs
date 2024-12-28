using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace WebApplication4.Pages
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public Credentials credentials { get; set; }


        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly EntityMaterializerSource
        
        public void OnGet()
        {

        }

        public async Task OnPost()
        {

        }
    }

    public class Credentials
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Require2FA { get; set; }
    }
}

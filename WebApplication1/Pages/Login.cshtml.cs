using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace WebApplication1.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credentials Credentials { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {

            if (Credentials.username == "Avinash" && Credentials.password == "123")
            {
                var claims = new List<Claim>() { new Claim(ClaimTypes.Name, Credentials.username) };

                var claimIdentiy = new ClaimsIdentity(claims, "MyCookieAuth");

                var claimPrincipal = new ClaimsPrincipal(claimIdentiy);

                var ispersistent = new AuthenticationProperties()
                {
                    IsPersistent = Credentials.isPersistent,
                };

                await HttpContext.SignInAsync("MyCookieAuth", claimPrincipal, ispersistent);

                 return RedirectToPage("/Index");
            }

            return Page();
        }
    }

    public class Credentials
    {
        public string username { get; set; }
        public string password { get; set; }

        public bool isPersistent { get; set; }
    }
}


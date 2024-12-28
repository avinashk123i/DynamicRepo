using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnPost()
        {
           await HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToPage("/Login");
        }
    }
}

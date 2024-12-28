using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace MinimalApiOauth
{
    public class CustomHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public CustomHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
        {
           
        }
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var code = Request.Headers["Authorization"].ToString();
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "CustomUser"),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var identity = new ClaimsIdentity(claims, "MyAuth");
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, "MyAuth");

            return Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
}

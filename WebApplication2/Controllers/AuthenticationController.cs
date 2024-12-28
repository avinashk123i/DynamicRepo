using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    
    public class AuthenticationController : ControllerBase
    {
        private IDistributedCache _distributedCache;
        public AuthenticationController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        [HttpPost(Name = "Token")]
        public async Task<IActionResult> GetToken([FromBody] Credentials credentials)
        {
            if (credentials.UserName == "Avinash" && credentials.Password == "123")
            {
                var claims = new List<Claim>() { new Claim(ClaimTypes.Name, credentials.UserName) };

                var claimIdentiy = new ClaimsIdentity(claims, "MyCookieAuth");

                var claimPrincipal = new ClaimsPrincipal(claimIdentiy);

                var token = new JwtSecurityToken(null, null, claims, null, DateTime.Now.AddMinutes(60), new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes("abccccccccccccccccccccccccccccccccc")), SecurityAlgorithms.HmacSha256));

                return Ok(await GetTokenFromCache(token));

            }

            return BadRequest();

        }

        private async Task<string> GetTokenFromCache(JwtSecurityToken token)
        {
            
                await _distributedCache.SetStringAsync("token", new JwtSecurityTokenHandler().WriteToken(token));

            

            return await _distributedCache.GetStringAsync("token") ?? string.Empty;
        }

        public class Credentials
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}

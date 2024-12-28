using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3
{
    public class AppContext : IdentityDbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
                
        }
    }
}

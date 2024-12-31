using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationDBContext : DbContext
    {
        // Creating the application db context for the inMemory database 
        // * This class should reside inside the Infrastructure layer for more decoupling.
        public DbSet<Teacher> teachers { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

    }
}

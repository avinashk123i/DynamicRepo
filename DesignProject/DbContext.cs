using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject
{
    public class AvContext : DbContext
    {
       public DbSet<context> Context { get; set; }

        public DbSet<context2> context2s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=L70525;Database=Context;Integrated Security=True;Encrypt=False");
        }

    }
}

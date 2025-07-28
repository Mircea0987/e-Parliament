using e_Parliament.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.DbContextApp
{
    internal class AppDbContext : DbContext
    {
        public DbSet<AccountType> accountTypes { get; set; }
        public DbSet<Users> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=e_Parliament;Username=postgres;Password=admin");
            //pg connection string
        }
    }
}

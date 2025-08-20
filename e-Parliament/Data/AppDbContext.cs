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
        public string connectionString { get; }
        public DbSet<AccountType> account_types { get; set; }
        public DbSet<Users> users { get; set; }
        public AppDbContext()
        {
            connectionString = "Host=localhost;Database=e_Parliament;Username=postgres;Password=admin";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            //pg connection string
        }
    }
}

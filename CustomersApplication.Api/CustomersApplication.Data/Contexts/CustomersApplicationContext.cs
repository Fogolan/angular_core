using CustomersApplication.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomersApplication.Data.Contexts
{
    public class CustomersApplicationContext : IdentityDbContext<UserIdentity>
    {
        public CustomersApplicationContext(DbContextOptions<CustomersApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
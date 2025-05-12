using Microsoft.EntityFrameworkCore;

namespace PasswordManagerAPI.Context
{
    public class PasswordManagerDbContext : DbContext
    {
        public PasswordManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

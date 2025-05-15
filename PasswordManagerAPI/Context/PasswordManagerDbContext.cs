using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Helpers;

namespace PasswordManagerAPI.Context
{
    public class PasswordManagerDbContext : DbContext
    {
        public DbSet<LookupType> LookupTypes { get; set; }
        public DbSet<LookupItem> LookupItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public PasswordManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LookupType>().HasData( 
                new LookupType { Id = 1, Name = "Nationality"},
                new LookupType { Id = 2, Name = "Role"},
                new LookupType { Id = 3, Name = "UserNameType"},
                new LookupType { Id = 4, Name = "Specialization"},
                new LookupType { Id = 5, Name = "Category"}
                );
            modelBuilder.Entity<LookupItem>().HasData(
               new LookupItem { Id = 10, Name = "Jordanian", LookupTypeID = 1 },
                new LookupItem { Id = 1, Name = "Client", LookupTypeID = 2 },
                new LookupItem { Id = 2, Name = "Admin", LookupTypeID = 2 },
                new LookupItem { Id = 100, Name = "Phone", LookupTypeID = 3 },
                new LookupItem { Id = 101, Name = "Name", LookupTypeID = 3 },
                new LookupItem { Id = 102, Name = "Email", LookupTypeID = 3 },
                new LookupItem { Id = 103, Name = "UserName", LookupTypeID = 3 },
                new LookupItem { Id = 104, Name = "National ID", LookupTypeID = 3 },
                new LookupItem { Id = 200, Name = "Trainer", LookupTypeID = 4 },
                new LookupItem { Id = 201, Name = "Manger", LookupTypeID = 4 },
                new LookupItem { Id = 300, Name = "Personal", LookupTypeID = 5 },
                new LookupItem { Id = 301, Name = "Banking", LookupTypeID = 5 },
                new LookupItem { Id = 302, Name = "Social Media", LookupTypeID = 5 },
                new LookupItem { Id = 303, Name = "Other", LookupTypeID = 5 }
                );
            
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = HashingHelper.HashValue384("ahmadmadaljeh@gmail.com"),
                    Password = HashingHelper.HashValue384("aaaa@123000"),
                    Username = HashingHelper.HashValue384("AHM"),
                    RoleId = 2,
                    IsVerfied = true
                }
                );
        }
    }
}

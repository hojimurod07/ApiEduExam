

using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Data.DB;

public  class AppDbContext(DbContextOptions<AppDbContext> opt) : DbContext(opt)
{

    public DbSet<User> Users { get; set; }

    public DbSet<Fan> Fans { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FullName = "superAdmin",
                Email = "hojimurad007@gmail.com",
                Gender = Gender.Male,
                Password = "08c1e89c0590b66c452d7370540b2dc6cf8be5c381a18f6ae5de234069ff79e2",
                Role = Role.SuperAdmin
            });
    }
}



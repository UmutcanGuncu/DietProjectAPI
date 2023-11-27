using System;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DietProject.DataAccessLayer.Context
{
    public class DietDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public DietDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Food> foods { get; set; }
        public DbSet<Meal> meals { get; set; }
        public DbSet<UserInformation> userInformation { get; set; }
    }
}


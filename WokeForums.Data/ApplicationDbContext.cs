using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using WokeForums.Data.Models;

//Creates database schema based on models

namespace WokeForums.Data
{
    //interacts with data as objects
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> AppUser { get; set; } 
    }
} 

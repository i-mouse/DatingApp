using Microsoft.EntityFrameworkCore;
using DatingAppAPI.Entities;

namespace DatingAppAPI.AppDataBase
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUsers> AppUsers { get; set; }
    }
}

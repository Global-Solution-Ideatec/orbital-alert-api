using Microsoft.EntityFrameworkCore;
using OrbitalAlert.API.Models;

namespace OrbitalAlert.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Alert> Alerts { get; set; }
    }
}
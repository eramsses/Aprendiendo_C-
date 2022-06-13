using DB.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Data
{
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> option) : base(option)
        {

        }

        public DbSet<Beer> Beers { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}
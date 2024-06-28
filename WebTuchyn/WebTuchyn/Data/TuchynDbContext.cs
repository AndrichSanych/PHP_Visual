using Microsoft.EntityFrameworkCore;

namespace WebTuchyn.Data
{
    public class TuchynDbContext : DbContext
    {
        public TuchynDbContext(DbContextOptions<TuchynDbContext> options) : base(options)
        { }

        public DbSet<DogEntity> Dogs { get; set; }

    }
}

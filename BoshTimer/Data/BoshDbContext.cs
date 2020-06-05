using BoshTimer.Models;
using Microsoft.EntityFrameworkCore;

namespace BoshTimer.Data
{
    public class BoshDbContext : DbContext
    {
        public BoshDbContext(DbContextOptions<BoshDbContext> options)
            : base(options)
        {
        }

        public DbSet<Routine> Routine { get; set; }
    }
}

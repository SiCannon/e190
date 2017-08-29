using Microsoft.EntityFrameworkCore;

namespace e190.Model
{
    public class PieContext : DbContext
    {
        public DbSet<Pie> Pies { get; set; }

        public PieContext(DbContextOptions<PieContext> options) : base(options)
        {
            
        }

    }
}
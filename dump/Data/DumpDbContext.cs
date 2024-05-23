using dump.Model;
using Microsoft.EntityFrameworkCore;

namespace dump.Data
{
    public class DumpDbContext : DbContext
    {
        public DumpDbContext(DbContextOptions<DumpDbContext> options) : base(options)
        {

        }
        public DbSet<ForDoB> DoB { get; set; }

        public DbSet<ForFluent> Fluent { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ForFluent>()
                .Property(p => p.Discount)
                .HasColumnType("decimal(18,2)");
        }
    }
}

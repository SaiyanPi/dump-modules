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
        public DbSet<ForUniqueProp> Emp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ForFluent>().Property(p => p.Discount).HasColumnType("decimal(18,2)");

            //For Unique Model Property
            // Making 'Card' alternate key hence unique with Fluent(Do not forget to migrate & update db!)
            modelBuilder.Entity<ForUniqueProp>().HasAlternateKey(a => a.Card);
            //modelBuilder.Entity<ForUniqueProp>().HasAlternateKey(a => new {a.Card, a.Role }); //for multiple property
        }
      
    }
}

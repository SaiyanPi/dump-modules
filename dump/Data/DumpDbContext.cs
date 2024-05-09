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
    }
}

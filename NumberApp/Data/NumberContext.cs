using Microsoft.EntityFrameworkCore;
using NumberApp.Models;

namespace NumberApp.Data
{
    public class NumberContext : DbContext
    {
        public NumberContext(DbContextOptions<NumberContext> options) : base(options) { }

        public DbSet<NumberEntry> NumberEntries { get; set; }
    }
}

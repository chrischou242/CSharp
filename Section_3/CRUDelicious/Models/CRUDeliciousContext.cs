using Microsoft.EntityFrameworkCore;
 
namespace CRUDelicious.Models
{
    public class CRUDeliciousContext : DbContext
    {
        public CRUDeliciousContext(DbContextOptions options) : base(options) { }
 
        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<Food> Foods { get; set; }
        public object Posts { get; internal set; }

        // public DbSet<Widget> Widgets { get; set; }
        // public DbSet<Item> Items { get; set; }
    }
}

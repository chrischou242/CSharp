using Microsoft.EntityFrameworkCore;
 
namespace Login_Reg.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions options) : base(options) { }
 
        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }
 
        // public DbSet<Widget> Widgets { get; set; }
        // public DbSet<Item> Items { get; set; }
    }
}

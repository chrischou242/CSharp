
using Test_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Test_1.Models
{
    public class Test_1Context : DbContext
    {
        public Test_1Context (DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }

        public DbSet<Activityy> Activities {get;set;}

        public DbSet<Join> Joins{get;set;}
    }

}
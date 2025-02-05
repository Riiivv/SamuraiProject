using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SamuraiProject.Library.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DatabaseContext()
        {

        }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Samurai> Samurai { get; set; } // this is a table, named Samurai, PK SamuraiId
        public DbSet<Horse> Horse { get; set; }
        public DbSet<Battle> Battle { get; set; }
    }
}

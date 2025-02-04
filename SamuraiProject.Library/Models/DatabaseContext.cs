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
        public DbSet<Samurai> Samurai { get; set; } // this is a table, named Samurai, PK SamuraiId

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

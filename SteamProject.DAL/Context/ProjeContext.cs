using ClassLibrary1.ORM.Entity.Concerte;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamProject.DAL.Context
{
  public  class ProjeContext:DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=Steam;Integrated Security = True;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}

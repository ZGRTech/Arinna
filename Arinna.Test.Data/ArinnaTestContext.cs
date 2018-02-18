using Arinna.Test.Model;
using Arinna.Test.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Data
{
    public class ArinnaTestContext : DbContext
    {
        public ArinnaTestContext() : base("ArinnaTestContext")
        {
            Database.SetInitializer<ArinnaTestContext>(null);

            this.Configuration.LazyLoadingEnabled = false;
        }

<<<<<<< HEAD
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
=======
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
>>>>>>> origin/master
    }
}

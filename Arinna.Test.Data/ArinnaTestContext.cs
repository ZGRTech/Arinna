using Arinna.Test.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

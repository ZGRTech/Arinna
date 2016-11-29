using Marduk.Test.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marduk.Test.Data
{
    public class MardukTestContextSeeder : DropCreateDatabaseAlways<MardukTestContext>
    {
        protected override void Seed(MardukTestContext context)
        {
            context.Categories.AddRange(new List<Category>
            {
                new Category { CategoryName = "Category1", IsActive = true },
                new Category { CategoryName = "Category2", IsActive = true },
                new Category { CategoryName = "Category3", IsActive = false }
            });
            context.Products.AddRange(new List<Product>
            {
                new Product{ ProductName = "Product1", IsActive = true, CategoryId = 1 },
                new Product{ ProductName = "Product2", IsActive = true, CategoryId = 1 },
                new Product{ ProductName = "Product3", IsActive = false, CategoryId = 1 },
                new Product{ ProductName = "Product4", IsActive = true, CategoryId = 2 },
                new Product{ ProductName = "Product5", IsActive = true, CategoryId = 3 },
                new Product{ ProductName = "Product6", IsActive = false, CategoryId = 3 }
            });
            base.Seed(context);
        }
    }
}

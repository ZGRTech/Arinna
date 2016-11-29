using Marduk.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marduk.Test.Model
{
    public class Product : BaseModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}

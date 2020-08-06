using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Data
{
    public interface IDeletableEntity
    {
        public bool IsDeleted { get; set; }
    }
}
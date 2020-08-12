using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arinna.Data
{
    public abstract class Entity<T> : BaseEntity
    {
        [Key]
        public virtual T Id { get; set; }
    }
}

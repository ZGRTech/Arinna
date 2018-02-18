using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model.Models
{
    public class SoftDeletableEntity<TIdType> : BaseEntity<TIdType>, ISoftDeletableEntity
    {
        public bool IsDeleted { get; set; }
    }
}

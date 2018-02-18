using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model.Interfaces
{
    public interface ISoftDeletableEntity
    {
        bool IsDeleted { get; set; }
    }
}

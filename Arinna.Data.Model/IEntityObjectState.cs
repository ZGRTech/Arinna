using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model
{
    public interface IEntityObjectState
    {
        EntityObjectState ObjectState { get; set; }
    }
}

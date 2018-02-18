using Arinna.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model.Interfaces
{
    public interface IObjectState
    {
        EntityObjectState ObjectState { get; set; }
    }
}

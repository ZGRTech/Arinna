using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}

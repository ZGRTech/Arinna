using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();

        //Task<int> CompleteAsync();
    }
}

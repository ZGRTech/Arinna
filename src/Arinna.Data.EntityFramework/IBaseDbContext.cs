using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Data.EntityFramework
{
    public interface IBaseDbContext : IDisposable
    {
        int SaveChanges();
    }
}

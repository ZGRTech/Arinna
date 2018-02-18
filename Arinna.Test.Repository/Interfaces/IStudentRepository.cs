using Arinna.Data.Interfaces;
using Arinna.Test.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq.Expressions;

namespace Arinna.Test.Service.Interfaces
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        
    }
}

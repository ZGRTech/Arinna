using Arinna.Test.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arinna.Test.Model.Entities;
using System.Data;
using System.Linq.Expressions;
using Arinna.Data.UnitOfWork;
using Arinna.Data.Repositories;
using System.Data.Entity;

namespace Arinna.Test.Service.Services
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context) : base(context)
        {
            
        }
    }
}

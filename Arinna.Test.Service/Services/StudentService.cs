using Arinna.Test.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arinna.Test.Model.Entities;
using System.Data;
using System.Linq.Expressions;
using Arinna.Test.Data;
using Arinna.Data.UnitOfWork;
using Arinna.Data.Repositories;
using System.Data.Entity;
using Arinna.Test.Service.Services;
using Arinna.Data.Interfaces;
using Arinna.Data.Services;

namespace Arinna.Test.Service.Services
{
    public class StudentService : IBaseService<Student>
    {
        public Student Get(Expression<Func<Student, bool>> predicate)
        {
            return new BaseService<Student>(new ArinnaTestContext()).Get(predicate);
        }

        public Student Get(Expression<Func<Student, bool>> predicate, Expression<Func<Student, object>> path)
        {
            return new BaseService<Student>(new ArinnaTestContext()).Get(predicate, path);
        }

        public IEnumerable<Student> GetAll()
        {
            return new BaseService<Student>(new ArinnaTestContext()).GetAll();
        }

        public IEnumerable<Student> GetAll(Expression<Func<Student, bool>> predicate)
        {
            return new BaseService<Student>(new ArinnaTestContext()).GetAll(predicate);
        }

        public IEnumerable<Student> GetAll(Expression<Func<Student, bool>> predicate, Expression<Func<Student, object>> path)
        {
            return new BaseService<Student>(new ArinnaTestContext()).GetAll(predicate, path);
        }

        public int Count()
        {
            return new BaseService<Student>(new ArinnaTestContext()).Count();
        }

        public int Count(Expression<Func<Student, bool>> predicate)
        {
            return new BaseService<Student>(new ArinnaTestContext()).Count(predicate);
        }

        public bool Any()
        {
            return new BaseService<Student>(new ArinnaTestContext()).Any();
        }

        public bool Any(Expression<Func<Student, bool>> predicate)
        {
            return new BaseService<Student>(new ArinnaTestContext()).Any(predicate);
        }

        public void Add(Student entity)
        {
            new BaseService<Student>(new ArinnaTestContext()).Add(entity);
        }

        public void AddRange(IEnumerable<Student> entities)
        {
            new BaseService<Student>(new ArinnaTestContext()).AddRange(entities);
        }

        public void Update(Student entity)
        {
            new BaseService<Student>(new ArinnaTestContext()).Update(entity);
        }

        public void UpdateRange(IEnumerable<Student> entities)
        {
            new BaseService<Student>(new ArinnaTestContext()).UpdateRange(entities);
        }

        public void Remove(Student entity)
        {
            new BaseService<Student>(new ArinnaTestContext()).Remove(entity);
        }

        public void RemoveRange(IEnumerable<Student> entities)
        {
            new BaseService<Student>(new ArinnaTestContext()).RemoveRange(entities);
        }

        public void RunCrudOperation(Student entity)
        {
            new BaseService<Student>(new ArinnaTestContext()).RunCrudOperation(entity);
        }

        public void RunCrudOperationRange(IEnumerable<Student> entities)
        {
            new BaseService<Student>(new ArinnaTestContext()).RunCrudOperationRange(entities);
        }

        public void ExecuteSqlCommand(string sql, object[] parameters)
        {
            new BaseService<Student>(new ArinnaTestContext()).ExecuteSqlCommand(sql, parameters);
        }

        public void ExecuteSqlCommand(IDbCommand sqlCommand)
        {
            new BaseService<Student>(new ArinnaTestContext()).ExecuteSqlCommand(sqlCommand);
        }

        public IEnumerable<Student> ExecuteSqlQuery(string sql, object[] parameters)
        {
            return new BaseService<Student>(new ArinnaTestContext()).ExecuteSqlQuery(sql, parameters);
        }

        public IEnumerable<Student> ExecuteSqlQuery(IDbCommand sqlCommand)
        {
            return new BaseService<Student>(new ArinnaTestContext()).ExecuteSqlQuery(sqlCommand);
        }



    }
}

using Arinna.Test.Service.Interfaces;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
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



=======
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arinna.Test.Model;
using System.Linq.Expressions;
using System.Security.Cryptography;
using Arinna.Test.Data;
using Arinna.Data.UnitOfWork;

namespace Arinna.Test.Service.Services
{
    public class StudentService : IStudentService
    {
        public Student GetStudent()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Get();
            }
        }

        public Student GetStudent(Expression<Func<Student, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Get(predicate);
            }
        }

        public Student GetStudent(Expression<Func<Student, bool>> predicate, Expression<Func<Student, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Get(predicate, path);
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().GetAll().ToList();
            }
        }

        public List<Student> GetAllStudents(Expression<Func<Student, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().GetAll(predicate).ToList();
            }
        }

        public List<Student> GetAllStudents(Expression<Func<Student, bool>> predicate, Expression<Func<Student, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().GetAll(predicate, path).ToList();
            }
        }

        public int StudentCount()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Count();
            }
        }

        public int StudentCount(Expression<Func<Student, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Count(predicate);
            }
        }

        public bool StudentAny()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Any();
            }
        }

        public bool StudentAny(Expression<Func<Student, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().Any(predicate);
            }
        }

        public void AddStudent(Student Student)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().Add(Student);
                uof.Complete();
            }
        }

        public void AddStudentRange(IEnumerable<Student> Students)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().AddRange(Students);
                uof.Complete();
            }
        }

        public void UpdateStudent(Student Student)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().Update(Student);
                uof.Complete();
            }
        }

        public void UpdateStudentRange(IEnumerable<Student> Students)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().UpdateRange(Students);
                uof.Complete();
            }
        }

        public void RemoveStudent(Student Student)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().Remove(Student);
                uof.Complete();
            }
        }

        public void RemoveStudentRange(IEnumerable<Student> Students)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().RemoveRange(Students);
                uof.Complete();
            }
        }

        public void RunCrudStudentOperation(Student Student)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().RunCrudOperation(Student);
                uof.Complete();
            }
        }

        public void RunCrudStudentOperationRange(IEnumerable<Student> Students)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().RunCrudOperationRange(Students);
                uof.Complete();
            }
        }

        public void ExecuteStudentSqlCommand(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().ExecuteSqlCommand(sql, parameters);
            }
        }

        public void ExecuteStudentSqlCommand(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Student>().ExecuteSqlCommand(sqlCommand);
            }
        }

        public List<Student> ExecuteStudentSqlQuery(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().ExecuteSqlQuery(sql, parameters).ToList();
            }
        }

        public List<Student> ExecuteStudentSqlQuery(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Student>().ExecuteSqlQuery(sqlCommand).ToList();
            }
        }

        //public List<StudentDto> ExecuteStudentDtoSqlQuery(string sql, params object[] parameters)
        //{
        //    using (var uof = new UnitOfWork(new ArinnaTestContext()))
        //    {
        //        return uof.GetRepository<Student>().ExecuteSqlQuery<StudentDto>(sql, parameters).ToList();
        //    }
        //}

        //public List<StudentDto> ExecuteStudentDtoSqlQuery(IDbCommand sqlCommand)
        //{
        //    using (var uof = new UnitOfWork(new ArinnaTestContext()))
        //    {
        //        return uof.GetRepository<Student>().ExecuteSqlQuery<StudentDto>(sqlCommand).ToList();
        //    }
        //}
>>>>>>> origin/master
    }
}

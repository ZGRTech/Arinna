using Arinna.Test.Service.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}

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
    public class TeacherService : ITeacherService
    {
        public Teacher GetTeacher()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Get();
            }
        }

        public Teacher GetTeacher(Expression<Func<Teacher, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Get(predicate);
            }
        }

        public Teacher GetTeacher(Expression<Func<Teacher, bool>> predicate, Expression<Func<Teacher, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Get(predicate, path);
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().GetAll().ToList();
            }
        }

        public List<Teacher> GetAllTeachers(Expression<Func<Teacher, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().GetAll(predicate).ToList();
            }
        }

        public List<Teacher> GetAllTeachers(Expression<Func<Teacher, bool>> predicate, Expression<Func<Teacher, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().GetAll(predicate, path).ToList();
            }
        }

        public int TeacherCount()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Count();
            }
        }

        public int TeacherCount(Expression<Func<Teacher, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Count(predicate);
            }
        }

        public bool TeacherAny()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Any();
            }
        }

        public bool TeacherAny(Expression<Func<Teacher, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().Any(predicate);
            }
        }

        public void AddTeacher(Teacher Teacher)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().Add(Teacher);
                uof.Complete();
            }
        }

        public void AddTeacherRange(IEnumerable<Teacher> Teachers)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().AddRange(Teachers);
                uof.Complete();
            }
        }

        public void UpdateTeacher(Teacher Teacher)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().Update(Teacher);
                uof.Complete();
            }
        }

        public void UpdateTeacherRange(IEnumerable<Teacher> Teachers)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().UpdateRange(Teachers);
                uof.Complete();
            }
        }

        public void RemoveTeacher(Teacher Teacher)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().Remove(Teacher);
                uof.Complete();
            }
        }

        public void RemoveTeacherRange(IEnumerable<Teacher> Teachers)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().RemoveRange(Teachers);
                uof.Complete();
            }
        }

        public void RunCrudTeacherOperation(Teacher Teacher)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().RunCrudOperation(Teacher);
                uof.Complete();
            }
        }

        public void RunCrudTeacherOperationRange(IEnumerable<Teacher> Teachers)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().RunCrudOperationRange(Teachers);
                uof.Complete();
            }
        }

        public void ExecuteTeacherSqlCommand(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().ExecuteSqlCommand(sql, parameters);
            }
        }

        public void ExecuteTeacherSqlCommand(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Teacher>().ExecuteSqlCommand(sqlCommand);
            }
        }

        public List<Teacher> ExecuteTeacherSqlQuery(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().ExecuteSqlQuery(sql, parameters).ToList();
            }
        }

        public List<Teacher> ExecuteTeacherSqlQuery(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Teacher>().ExecuteSqlQuery(sqlCommand).ToList();
            }
        }
    }
}

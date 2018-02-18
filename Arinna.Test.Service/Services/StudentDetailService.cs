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
    public class StudentDetailService : IStudentDetailService
    {
        public StudentDetail GetStudentDetail()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Get();
            }
        }

        public StudentDetail GetStudentDetail(Expression<Func<StudentDetail, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Get(predicate);
            }
        }

        public StudentDetail GetStudentDetail(Expression<Func<StudentDetail, bool>> predicate, Expression<Func<StudentDetail, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Get(predicate, path);
            }
        }

        public List<StudentDetail> GetAllStudentDetails()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().GetAll().ToList();
            }
        }

        public List<StudentDetail> GetAllStudentDetails(Expression<Func<StudentDetail, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().GetAll(predicate).ToList();
            }
        }

        public List<StudentDetail> GetAllStudentDetails(Expression<Func<StudentDetail, bool>> predicate, Expression<Func<StudentDetail, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().GetAll(predicate, path).ToList();
            }
        }

        public int StudentDetailCount()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Count();
            }
        }

        public int StudentDetailCount(Expression<Func<StudentDetail, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Count(predicate);
            }
        }

        public bool StudentDetailAny()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Any();
            }
        }

        public bool StudentDetailAny(Expression<Func<StudentDetail, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().Any(predicate);
            }
        }

        public void AddStudentDetail(StudentDetail StudentDetail)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().Add(StudentDetail);
                uof.Complete();
            }
        }

        public void AddStudentDetailRange(IEnumerable<StudentDetail> StudentDetails)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().AddRange(StudentDetails);
                uof.Complete();
            }
        }

        public void UpdateStudentDetail(StudentDetail StudentDetail)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().Update(StudentDetail);
                uof.Complete();
            }
        }

        public void UpdateStudentDetailRange(IEnumerable<StudentDetail> StudentDetails)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().UpdateRange(StudentDetails);
                uof.Complete();
            }
        }

        public void RemoveStudentDetail(StudentDetail StudentDetail)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().Remove(StudentDetail);
                uof.Complete();
            }
        }

        public void RemoveStudentDetailRange(IEnumerable<StudentDetail> StudentDetails)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().RemoveRange(StudentDetails);
                uof.Complete();
            }
        }

        public void RunCrudStudentDetailOperation(StudentDetail StudentDetail)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().RunCrudOperation(StudentDetail);
                uof.Complete();
            }
        }

        public void RunCrudStudentDetailOperationRange(IEnumerable<StudentDetail> StudentDetails)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().RunCrudOperationRange(StudentDetails);
                uof.Complete();
            }
        }

        public void ExecuteStudentDetailSqlCommand(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().ExecuteSqlCommand(sql, parameters);
            }
        }

        public void ExecuteStudentDetailSqlCommand(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<StudentDetail>().ExecuteSqlCommand(sqlCommand);
            }
        }

        public List<StudentDetail> ExecuteStudentDetailSqlQuery(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().ExecuteSqlQuery(sql, parameters).ToList();
            }
        }

        public List<StudentDetail> ExecuteStudentDetailSqlQuery(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<StudentDetail>().ExecuteSqlQuery(sqlCommand).ToList();
            }
        }
    }
}

using Arinna.Test.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Service.Interfaces
{
    public interface IStudentDetailService
    {
        StudentDetail GetStudentDetail();
        StudentDetail GetStudentDetail(Expression<Func<StudentDetail, bool>> predicate);
        StudentDetail GetStudentDetail(Expression<Func<StudentDetail, bool>> predicate, Expression<Func<StudentDetail, object>> path);

        List<StudentDetail> GetAllStudentDetails();
        List<StudentDetail> GetAllStudentDetails(Expression<Func<StudentDetail, bool>> predicate);
        List<StudentDetail> GetAllStudentDetails(Expression<Func<StudentDetail, bool>> predicate, Expression<Func<StudentDetail, object>> path);

        int StudentDetailCount();
        int StudentDetailCount(Expression<Func<StudentDetail, bool>> predicate);

        bool StudentDetailAny();
        bool StudentDetailAny(Expression<Func<StudentDetail, bool>> predicate);

        void AddStudentDetail(StudentDetail StudentDetail);
        void AddStudentDetailRange(IEnumerable<StudentDetail> StudentDetails);

        void UpdateStudentDetail(StudentDetail StudentDetail);
        void UpdateStudentDetailRange(IEnumerable<StudentDetail> StudentDetails);

        void RemoveStudentDetail(StudentDetail StudentDetail);
        void RemoveStudentDetailRange(IEnumerable<StudentDetail> StudentDetails);

        void RunCrudStudentDetailOperation(StudentDetail StudentDetail);
        void RunCrudStudentDetailOperationRange(IEnumerable<StudentDetail> StudentDetails);

        void ExecuteStudentDetailSqlCommand(string sql, params object[] parameters);
        void ExecuteStudentDetailSqlCommand(IDbCommand sqlCommand);

        List<StudentDetail> ExecuteStudentDetailSqlQuery(string sql, params object[] parameters);
        List<StudentDetail> ExecuteStudentDetailSqlQuery(IDbCommand sqlCommand);
    }
}

using Arinna.Test.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Service.Interfaces
{
    public interface IStudentService
    {
        Student GetStudent();
        Student GetStudent(Expression<Func<Student, bool>> predicate);
        Student GetStudent(Expression<Func<Student, bool>> predicate, Expression<Func<Student, object>> path);

        List<Student> GetAllStudents();
        List<Student> GetAllStudents(Expression<Func<Student, bool>> predicate);
        List<Student> GetAllStudents(Expression<Func<Student, bool>> predicate, Expression<Func<Student, object>> path);

        int StudentCount();
        int StudentCount(Expression<Func<Student, bool>> predicate);

        bool StudentAny();
        bool StudentAny(Expression<Func<Student, bool>> predicate);

        void AddStudent(Student Student);
        void AddStudentRange(IEnumerable<Student> Students);

        void UpdateStudent(Student Student);
        void UpdateStudentRange(IEnumerable<Student> Students);

        void RemoveStudent(Student Student);
        void RemoveStudentRange(IEnumerable<Student> Students);

        void RunCrudStudentOperation(Student Student);
        void RunCrudStudentOperationRange(IEnumerable<Student> Students);

        void ExecuteStudentSqlCommand(string sql, params object[] parameters);
        void ExecuteStudentSqlCommand(IDbCommand sqlCommand);

        List<Student> ExecuteStudentSqlQuery(string sql, params object[] parameters);
        List<Student> ExecuteStudentSqlQuery(IDbCommand sqlCommand);

        //List<StudentDto> ExecuteStudentDtoSqlQuery(string sql, params object[] parameters);
        //List<StudentDto> ExecuteStudentDtoSqlQuery(IDbCommand sqlCommand);
    }
}

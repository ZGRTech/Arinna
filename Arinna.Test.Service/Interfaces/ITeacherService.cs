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
    public interface ITeacherService
    {
        Teacher GetTeacher();
        Teacher GetTeacher(Expression<Func<Teacher, bool>> predicate);
        Teacher GetTeacher(Expression<Func<Teacher, bool>> predicate, Expression<Func<Teacher, object>> path);

        List<Teacher> GetAllTeachers();
        List<Teacher> GetAllTeachers(Expression<Func<Teacher, bool>> predicate);
        List<Teacher> GetAllTeachers(Expression<Func<Teacher, bool>> predicate, Expression<Func<Teacher, object>> path);

        int TeacherCount();
        int TeacherCount(Expression<Func<Teacher, bool>> predicate);

        bool TeacherAny();
        bool TeacherAny(Expression<Func<Teacher, bool>> predicate);

        void AddTeacher(Teacher Teacher);
        void AddTeacherRange(IEnumerable<Teacher> Teachers);

        void UpdateTeacher(Teacher Teacher);
        void UpdateTeacherRange(IEnumerable<Teacher> Teachers);

        void RemoveTeacher(Teacher Teacher);
        void RemoveTeacherRange(IEnumerable<Teacher> Teachers);

        void RunCrudTeacherOperation(Teacher Teacher);
        void RunCrudTeacherOperationRange(IEnumerable<Teacher> Teachers);

        void ExecuteTeacherSqlCommand(string sql, params object[] parameters);
        void ExecuteTeacherSqlCommand(IDbCommand sqlCommand);

        List<Teacher> ExecuteTeacherSqlQuery(string sql, params object[] parameters);
        List<Teacher> ExecuteTeacherSqlQuery(IDbCommand sqlCommand);
    }
}

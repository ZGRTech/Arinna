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
    public interface ICourseService
    {
        Course GetCourse();
        Course GetCourse(Expression<Func<Course, bool>> predicate);
        Course GetCourse(Expression<Func<Course, bool>> predicate, Expression<Func<Course, object>> path);

        List<Course> GetAllCourses();
        List<Course> GetAllCourses(Expression<Func<Course, bool>> predicate);
        List<Course> GetAllCourses(Expression<Func<Course, bool>> predicate, Expression<Func<Course, object>> path);

        int CourseCount();
        int CourseCount(Expression<Func<Course, bool>> predicate);

        bool CourseAny();
        bool CourseAny(Expression<Func<Course, bool>> predicate);

        void AddCourse(Course Course);
        void AddCourseRange(IEnumerable<Course> Courses);

        void UpdateCourse(Course Course);
        void UpdateCourseRange(IEnumerable<Course> Courses);

        void RemoveCourse(Course Course);
        void RemoveCourseRange(IEnumerable<Course> Courses);

        void RunCrudCourseOperation(Course Course);
        void RunCrudCourseOperationRange(IEnumerable<Course> Courses);

        void ExecuteCourseSqlCommand(string sql, params object[] parameters);
        void ExecuteCourseSqlCommand(IDbCommand sqlCommand);

        List<Course> ExecuteCourseSqlQuery(string sql, params object[] parameters);
        List<Course> ExecuteCourseSqlQuery(IDbCommand sqlCommand);
    }
}

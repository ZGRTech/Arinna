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
    public class CourseService : ICourseService
    {
        public Course GetCourse()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Get();
            }
        }

        public Course GetCourse(Expression<Func<Course, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Get(predicate);
            }
        }

        public Course GetCourse(Expression<Func<Course, bool>> predicate, Expression<Func<Course, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Get(predicate, path);
            }
        }

        public List<Course> GetAllCourses()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().GetAll().ToList();
            }
        }

        public List<Course> GetAllCourses(Expression<Func<Course, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().GetAll(predicate).ToList();
            }
        }

        public List<Course> GetAllCourses(Expression<Func<Course, bool>> predicate, Expression<Func<Course, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().GetAll(predicate, path).ToList();
            }
        }

        public int CourseCount()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Count();
            }
        }

        public int CourseCount(Expression<Func<Course, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Count(predicate);
            }
        }

        public bool CourseAny()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Any();
            }
        }

        public bool CourseAny(Expression<Func<Course, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().Any(predicate);
            }
        }

        public void AddCourse(Course Course)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().Add(Course);
                uof.Complete();
            }
        }

        public void AddCourseRange(IEnumerable<Course> Courses)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().AddRange(Courses);
                uof.Complete();
            }
        }

        public void UpdateCourse(Course Course)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().Update(Course);
                uof.Complete();
            }
        }

        public void UpdateCourseRange(IEnumerable<Course> Courses)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().UpdateRange(Courses);
                uof.Complete();
            }
        }

        public void RemoveCourse(Course Course)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().Remove(Course);
                uof.Complete();
            }
        }

        public void RemoveCourseRange(IEnumerable<Course> Courses)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().RemoveRange(Courses);
                uof.Complete();
            }
        }

        public void RunCrudCourseOperation(Course Course)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().RunCrudOperation(Course);
                uof.Complete();
            }
        }

        public void RunCrudCourseOperationRange(IEnumerable<Course> Courses)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().RunCrudOperationRange(Courses);
                uof.Complete();
            }
        }

        public void ExecuteCourseSqlCommand(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().ExecuteSqlCommand(sql, parameters);
            }
        }

        public void ExecuteCourseSqlCommand(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Course>().ExecuteSqlCommand(sqlCommand);
            }
        }

        public List<Course> ExecuteCourseSqlQuery(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().ExecuteSqlQuery(sql, parameters).ToList();
            }
        }

        public List<Course> ExecuteCourseSqlQuery(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Course>().ExecuteSqlQuery(sqlCommand).ToList();
            }
        }
    }
}

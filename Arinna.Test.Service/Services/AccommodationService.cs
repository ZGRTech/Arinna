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
    public class AccommodationService : IAccommodationService
    {
        public Accommodation GetAccommodation()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Get();
            }
        }

        public Accommodation GetAccommodation(Expression<Func<Accommodation, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Get(predicate);
            }
        }

        public Accommodation GetAccommodation(Expression<Func<Accommodation, bool>> predicate, Expression<Func<Accommodation, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Get(predicate, path);
            }
        }

        public List<Accommodation> GetAllAccommodations()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().GetAll().ToList();
            }
        }

        public List<Accommodation> GetAllAccommodations(Expression<Func<Accommodation, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().GetAll(predicate).ToList();
            }
        }

        public List<Accommodation> GetAllAccommodations(Expression<Func<Accommodation, bool>> predicate, Expression<Func<Accommodation, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().GetAll(predicate, path).ToList();
            }
        }

        public int AccommodationCount()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Count();
            }
        }

        public int AccommodationCount(Expression<Func<Accommodation, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Count(predicate);
            }
        }

        public bool AccommodationAny()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Any();
            }
        }

        public bool AccommodationAny(Expression<Func<Accommodation, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().Any(predicate);
            }
        }

        public void AddAccommodation(Accommodation Accommodation)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().Add(Accommodation);
                uof.Complete();
            }
        }

        public void AddAccommodationRange(IEnumerable<Accommodation> Accommodations)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().AddRange(Accommodations);
                uof.Complete();
            }
        }

        public void UpdateAccommodation(Accommodation Accommodation)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().Update(Accommodation);
                uof.Complete();
            }
        }

        public void UpdateAccommodationRange(IEnumerable<Accommodation> Accommodations)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().UpdateRange(Accommodations);
                uof.Complete();
            }
        }

        public void RemoveAccommodation(Accommodation Accommodation)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().Remove(Accommodation);
                uof.Complete();
            }
        }

        public void RemoveAccommodationRange(IEnumerable<Accommodation> Accommodations)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().RemoveRange(Accommodations);
                uof.Complete();
            }
        }

        public void RunCrudAccommodationOperation(Accommodation Accommodation)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().RunCrudOperation(Accommodation);
                uof.Complete();
            }
        }

        public void RunCrudAccommodationOperationRange(IEnumerable<Accommodation> Accommodations)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().RunCrudOperationRange(Accommodations);
                uof.Complete();
            }
        }

        public void ExecuteAccommodationSqlCommand(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().ExecuteSqlCommand(sql, parameters);
            }
        }

        public void ExecuteAccommodationSqlCommand(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Accommodation>().ExecuteSqlCommand(sqlCommand);
            }
        }

        public List<Accommodation> ExecuteAccommodationSqlQuery(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().ExecuteSqlQuery(sql, parameters).ToList();
            }
        }

        public List<Accommodation> ExecuteAccommodationSqlQuery(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Accommodation>().ExecuteSqlQuery(sqlCommand).ToList();
            }
        }
    }
}

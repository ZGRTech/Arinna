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
    public interface IAccommodationService
    {
        Accommodation GetAccommodation();
        Accommodation GetAccommodation(Expression<Func<Accommodation, bool>> predicate);
        Accommodation GetAccommodation(Expression<Func<Accommodation, bool>> predicate, Expression<Func<Accommodation, object>> path);

        List<Accommodation> GetAllAccommodations();
        List<Accommodation> GetAllAccommodations(Expression<Func<Accommodation, bool>> predicate);
        List<Accommodation> GetAllAccommodations(Expression<Func<Accommodation, bool>> predicate, Expression<Func<Accommodation, object>> path);

        int AccommodationCount();
        int AccommodationCount(Expression<Func<Accommodation, bool>> predicate);

        bool AccommodationAny();
        bool AccommodationAny(Expression<Func<Accommodation, bool>> predicate);

        void AddAccommodation(Accommodation Accommodation);
        void AddAccommodationRange(IEnumerable<Accommodation> Accommodations);

        void UpdateAccommodation(Accommodation Accommodation);
        void UpdateAccommodationRange(IEnumerable<Accommodation> Accommodations);

        void RemoveAccommodation(Accommodation Accommodation);
        void RemoveAccommodationRange(IEnumerable<Accommodation> Accommodations);

        void RunCrudAccommodationOperation(Accommodation Accommodation);
        void RunCrudAccommodationOperationRange(IEnumerable<Accommodation> Accommodations);

        void ExecuteAccommodationSqlCommand(string sql, params object[] parameters);
        void ExecuteAccommodationSqlCommand(IDbCommand sqlCommand);

        List<Accommodation> ExecuteAccommodationSqlQuery(string sql, params object[] parameters);
        List<Accommodation> ExecuteAccommodationSqlQuery(IDbCommand sqlCommand);
    }
}

using Marduk.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Marduk.Test.Service.Interfaces
{
    public interface ICategoryService
    {
        Category GetCategory(Expression<Func<Category, bool>> predicate);
        Category GetCategory(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path);

        List<Category> GetAllCategories();
        List<Category> GetAllCategories(Expression<Func<Category, bool>> predicate);
        List<Category> GetAllCategories(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path);

        int CategoryCount();
        int CategoryCount(Expression<Func<Category, bool>> predicate);

        bool CategoryAny();
        bool CategoryAny(Expression<Func<Category, bool>> predicate);

        void AddCategory(Category category);
        void AddCategoryRange(IEnumerable<Category> categories);

        void UpdateCategory(Category category);
        void UpdateCategoryRange(IEnumerable<Category> categories);

        void RemoveCategory(Category category);
        void RemoveCategoryRange(IEnumerable<Category> categories);

        void RunCrudCategoryOperation(Category category);
        void RunCrudCategoryOperationRange(IEnumerable<Category> categories);
    }
}

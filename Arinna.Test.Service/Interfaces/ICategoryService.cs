using Arinna.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Service.Interfaces
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

        Category GetCategoryAsync(Expression<Func<Category, bool>> predicates);
        Category GetCategoryAsync(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path);

        List<Category> GetAllCategorysAsync();
        List<Category> GetAllCategorysAsync(Expression<Func<Category, bool>> predicate);
        List<Category> GetAllCategorysAsync(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path);

        int CategoryCountAsync();
        int CategoryCountAsync(Expression<Func<Category, bool>> predicate);

        bool CategoryAnyAsync();
        bool CategoryAnyAsync(Expression<Func<Category, bool>> predicate);

        void AddCategoryAsync(Category category);
        void AddCategoryAsync(IEnumerable<Category> categories);

        void UpdateCategoryAsync(Category category);
        void UpdateCategoryAsync(IEnumerable<Category> categories);

        void RemoveCategoryAsync(Category category);
        void RemoveCategoryAsync(IEnumerable<Category> categories);

        void RunCrudCategoryOperationAsync(Category category);
        void RunCrudCategoryOperationRangeAsync(IEnumerable<Category> categories);
    }
}

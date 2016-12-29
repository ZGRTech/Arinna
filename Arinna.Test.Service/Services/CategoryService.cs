using Arinna.Test.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arinna.Test.Model;
using System.Linq.Expressions;
using Arinna.Data.UnitOfWork;
using Arinna.Test.Data;

namespace Arinna.Test.Service.Services
{
    public class CategoryService : ICategoryService
    {
        public Category GetCategory(Expression<Func<Category, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().Get(predicate);
            }
        }

        public Category GetCategory(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().Get(predicate, path);
            }
        }

        public List<Category> GetAllCategories()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().GetAll().ToList();
            }
        }

        public List<Category> GetAllCategories(Expression<Func<Category, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().GetAll(predicate).ToList();
            }
        }

        public List<Category> GetAllCategories(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().GetAll(predicate, path).ToList();
            }
        }

        public int CategoryCount()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().Count();
            }
        }

        public int CategoryCount(Expression<Func<Category, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().Count(predicate);
            }
        }

        public bool CategoryAny()
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().Any();
            }
        }

        public bool CategoryAny(Expression<Func<Category, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                return uof.GetRepository<Category>().Any(predicate);
            }
        }

        public void AddCategory(Category category)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().Add(category);
            }
        }

        public void AddCategoryRange(IEnumerable<Category> categories)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().AddRange(categories);
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().Update(category);
            }
        }

        public void UpdateCategoryRange(IEnumerable<Category> categories)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().UpdateRange(categories);
            }
        }

        public void RemoveCategory(Category category)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().Remove(category);
            }
        }

        public void RemoveCategoryRange(IEnumerable<Category> categories)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().RemoveRange(categories);
            }
        }

        public void RunCrudCategoryOperation(Category category)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().RunCrudOperation(category);
                uof.Complete();
            }
        }

        public void RunCrudCategoryOperationRange(IEnumerable<Category> categories)
        {
            using (var uof = new UnitOfWork(new ArinnaTestContext()))
            {
                uof.GetRepository<Category>().RunCrudOperationRange(categories);
                uof.Complete();
            }
        }


        public Category GetCategoryAsync(Expression<Func<Category, bool>> predicates)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryAsync(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategorysAsync()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategorysAsync(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategorysAsync(Expression<Func<Category, bool>> predicate, Expression<Func<Category, object>> path)
        {
            throw new NotImplementedException();
        }

        public int CategoryCountAsync()
        {
            throw new NotImplementedException();
        }

        public int CategoryCountAsync(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool CategoryAnyAsync()
        {
            throw new NotImplementedException();
        }

        public bool CategoryAnyAsync(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void AddCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public void AddCategoryAsync(IEnumerable<Category> categories)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoryAsync(IEnumerable<Category> categories)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategoryAsync(IEnumerable<Category> categories)
        {
            throw new NotImplementedException();
        }

        public void RunCrudCategoryOperationAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public void RunCrudCategoryOperationRangeAsync(IEnumerable<Category> categories)
        {
            throw new NotImplementedException();
        }
    }
}

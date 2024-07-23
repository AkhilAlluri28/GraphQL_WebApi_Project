using GraphQL_Project.Data;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Project.Repositories
{
    public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public Category AddCategory(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int categoryId)
        {
            Category? category = _appDbContext.Categories.FirstOrDefault(x => x.Id == categoryId);

            if(category is not null)
            {
                _appDbContext.Categories.Remove(category);
                _appDbContext.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            return _appDbContext.Categories.AsNoTracking().ToList();
        }

        public Category UpdateCategory(Category category)
        {
            _appDbContext.Categories.Update(category);
            _appDbContext.SaveChanges();
            return category;
        }

        public Category? GetCategory(int id)
        {
            return _appDbContext.Categories.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}

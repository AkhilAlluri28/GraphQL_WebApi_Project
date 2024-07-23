using GraphQL_Project.Models;

namespace GraphQL_Project.Interfaces
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
        public Category? GetCategory(int id);
        public Category AddCategory(Category category);
        public Category UpdateCategory(Category category);
        public void DeleteCategory(int categoryId);
    }
}

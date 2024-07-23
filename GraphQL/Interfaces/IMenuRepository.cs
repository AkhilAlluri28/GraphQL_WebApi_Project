using GraphQL_Project.Models;

namespace GraphQL_Project.Interfaces
{
    public interface IMenuRepository
    {
        public List<Menu> GetAllMenu();
        public Menu? GetMenu(int id);
        public Menu AddMenu(Menu menu);
        public Menu UpdateMenu(int id, Menu menu);
        public void DeleteMenu(int id);
    }
}

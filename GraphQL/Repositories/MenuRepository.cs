using GraphQL_Project.Data;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Project.Repositories
{
    public class MenuRepository(AppDbContext appDbContext) : IMenuRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public Menu AddMenu(Menu menu)
        {
            _appDbContext.Menus.Add(menu);
            _appDbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            Menu? menu = _appDbContext.Menus.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if(menu is not null)
            {
                _appDbContext.Menus.Remove(menu);
                _appDbContext.SaveChanges();
            }
        }

        public List<Menu> GetAllMenu()
        {
            return _appDbContext.Menus.AsNoTracking().ToList();
        }

        public Menu? GetMenu(int id)
        {
            return _appDbContext.Menus.AsNoTracking().FirstOrDefault(x=>x.Id == id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            _appDbContext.Menus.Update(menu);
            _appDbContext.SaveChanges();
            return menu;
        }
    }
}

using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;

namespace GraphQL_Project.Types
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepository menuRepository)
        {
            Field(x => x.Id).Description("Unique identifier of category");
            Field(x => x.Name).Description("Name of category");
            Field<ListGraphType<MenuType>>("menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });
        }
    }
}

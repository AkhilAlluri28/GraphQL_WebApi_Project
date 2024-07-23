using GraphQL;
using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Types;

namespace GraphQL_Project.Queries
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuRepository menuRepository)
        {
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });

            Field<MenuType>("MenuById").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" }))
                .Resolve(context =>
                {
                    return menuRepository.GetMenu(context.GetArgument<int>("menuId"));
                });
        }
    }
}

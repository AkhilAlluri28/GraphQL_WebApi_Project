using GraphQL;
using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;
using GraphQL_Project.Types;

namespace GraphQL_Project.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {
            Field<MenuType>("CreateMenu")
                .Arguments(new QueryArguments(
                    new QueryArgument<MenuInputType> { Name = "menu" }))
                .Resolve(context => {
                return menuRepository.AddMenu(context.GetArgument<Menu>("menu"));
            });

            Field<MenuType>("UpdateMenu")
                .Arguments(new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "id"},
                    new QueryArgument<MenuInputType> { Name = "menu" }))
                .Resolve(context =>
            {
                return menuRepository.UpdateMenu(context.GetArgument<int>("id"), context.GetArgument<Menu>("menu"));
            });

            Field<BooleanGraphType>("DeleteMenu")
                .Arguments(new QueryArguments(
                    new QueryArgument<IntGraphType> { Name ="id"}))
                .Resolve(context =>
                {
                    menuRepository.DeleteMenu(context.GetArgument<int>("id"));
                    return true;
                });
        }
    }
}

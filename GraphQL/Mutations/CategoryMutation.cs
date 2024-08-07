using GraphQL;
using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;
using GraphQL_Project.Types;

namespace GraphQL_Project.Mutations
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository categoryRepository)
        {
            Field<CategoryType>("CreateCategory")
                .Arguments(new QueryArguments(
                    new QueryArgument<CategoryInputType> { Name = "category" }))
                .Resolve(context => {
                    return categoryRepository.AddCategory(context.GetArgument<Category>("category"));
                });

            Field<CategoryType>("UpdateCategory")
                .Arguments(new QueryArguments(
                    new QueryArgument<CategoryInputType> { Name = "category" }))
                .Resolve(context => {
                    return categoryRepository.UpdateCategory(context.GetArgument<Category>("category"));
                });

            Field<BooleanGraphType>("DeleteCategory")
                .Arguments(new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "id" }))
                .Resolve(context => {
                    categoryRepository.DeleteCategory(context.GetArgument<int>("id"));
                    return true;
                });
        }
    }
}

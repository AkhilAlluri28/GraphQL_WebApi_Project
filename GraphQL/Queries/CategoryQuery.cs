using GraphQL;
using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Types;

namespace GraphQL_Project.Queries
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            Field<ListGraphType<CategoryType>>("categories").Resolve(context => categoryRepository.GetCategories());
            Field<CategoryType>("categoryById").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId"}))
                .Resolve(context => categoryRepository.GetCategory(context.GetArgument<int>("categoryId")));
        }
    }
}

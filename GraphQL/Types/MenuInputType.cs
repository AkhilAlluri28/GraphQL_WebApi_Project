using GraphQL.Types;

namespace GraphQL_Project.Types
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType() 
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
            Field<StringGraphType>("imageUrl");
            Field<IntGraphType>("categoryId");
        }
    }
}

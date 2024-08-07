using GraphQL.Types;

namespace GraphQL_Project.Types
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            //Field<ListGraphType<MenuType>>("menus");
        }
    }
}

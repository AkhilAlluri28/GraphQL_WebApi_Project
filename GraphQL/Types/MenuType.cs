using GraphQL.Types;
using GraphQL_Project.Models;

namespace GraphQL_Project.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType() 
        {
            Field(x => x.Id).Description("Id of the item in Menu");
            Field(x => x.Name).Description("Name of the item in Menu");
            Field(x => x.Description).Description("Description of the item in Menu");
            Field(x => x.Price).Description("Price of the item in Menu");
            Field(x => x.ImageUrl).Description("Image of the item in Menu");
            Field(x => x.CategoryId).Description("Category identifier of the item in Menu");
        }
    }
}

using GraphQL.Types;

namespace GraphQL_Project.Queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery() 
        {
            Field<CategoryQuery>("categoryQuery").Resolve(context => new { });
            Field<MenuQuery>("menuQuery").Resolve(context => new { });
            Field<ReservationQuery>("reservationQuery").Resolve(context => new { });
        }
    }
}

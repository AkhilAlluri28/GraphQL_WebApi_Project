using GraphQL.Types;
using GraphQL_Project.Models;

namespace GraphQL_Project.Types
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(x => x.Id).Description("Id of the reservation");
            Field(x => x.CustomerName).Description("Customer name of the reservation");
            Field(x => x.Email).Description("Email of the reservation customer");
            Field(x => x.PhoneNumber).Description("Phone of the reservation customer\"");
            Field(x => x.PartySize).Description("Part size");
            Field(x => x.SpecialRequest).Description("Any special request from party");
            Field(x => x.ReservationDate).Description("Reservation date!");
        }
    }
}

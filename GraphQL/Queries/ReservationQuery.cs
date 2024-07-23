using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Types;

namespace GraphQL_Project.Queries
{
    public class ReservationQuery: ObjectGraphType
    {
        public ReservationQuery(IReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("reservations").Resolve(context => reservationRepository.GetReservations());
        }
    }
}

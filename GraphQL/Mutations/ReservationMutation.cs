using GraphQL;
using GraphQL.Types;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;
using GraphQL_Project.Types;

namespace GraphQL_Project.Mutations
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationRepository reservationRepository)
        {
            Field<ReservationType>("CreateReservation")
                .Arguments(new QueryArguments(
            new QueryArgument<ReservationInputType> { Name = "reservation" }))
                .Resolve(context => {
                    return reservationRepository.AddReservation(context.GetArgument<Reservation>("reservation"));
                });
        }
    }
}

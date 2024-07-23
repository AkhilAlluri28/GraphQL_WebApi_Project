using GraphQL_Project.Models;

namespace GraphQL_Project.Interfaces
{
    public interface IReservationRepository
    {
        public List<Reservation> GetReservations();
        public Reservation AddReservation(Reservation reservation);
    }
}

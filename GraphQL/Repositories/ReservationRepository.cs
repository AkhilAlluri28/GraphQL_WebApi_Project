using GraphQL_Project.Data;
using GraphQL_Project.Interfaces;
using GraphQL_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Project.Repositories
{
    public class ReservationRepository(AppDbContext appDbContext) : IReservationRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public Reservation AddReservation(Reservation reservation)
        {
            _appDbContext.Reservations.Add(reservation);
            _appDbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _appDbContext.Reservations.AsNoTracking().ToList();
        }
    }
}

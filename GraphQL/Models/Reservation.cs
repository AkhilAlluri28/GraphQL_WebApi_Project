namespace GraphQL_Project.Models
{
    public record Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int PartySize { get; set; }
        public string SpecialRequest { get; set;} = null!;
        public DateTime ReservationDate { get; set; }
    }
}

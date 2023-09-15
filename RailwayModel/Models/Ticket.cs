using System.ComponentModel.DataAnnotations;

namespace RailwayModel.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string? TicketNumber { get; set; }

        [Required]
        public Passenger? Passenger { get; set; }

        public Station? DepartureStation { get; set; }
        public Station? ArrivalStation { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DepartureDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal? TicketPrice { get; set; }
    }
}

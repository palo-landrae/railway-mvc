using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
  public class DBTicketBooking
  {
    [Key]
    public int BookingId { get; set; }

    [Required]
    public int PassengerId { get; set; }

    [Required]
    public string TicketId { get; set; }

    [Required]
    public DateTime BookingDate { get; set; } = DateTime.Now;

    public DBPassenger Passenger { get; set; }
    public DBTicket Ticket { get; set; }
  }
}

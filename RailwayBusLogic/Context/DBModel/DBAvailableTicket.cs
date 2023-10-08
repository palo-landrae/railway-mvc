using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
  public class DBAvailableTicket
  {
    [Key]
    public string ticketId { get; set; }

    [Required]
    public decimal price { get; set; }

    [Required]
    public string trainName { get; set; }

    [Required]
    public string line { get; set; }

    [Required]
    public string departureStation { get; set; }

    [Required]
    public string arrivalStation { get; set; }

    [Required]
    public DateTime departureTime { get; set; }

    [Required]
    public DateTime arrivalTime { get; set; }
  }
}

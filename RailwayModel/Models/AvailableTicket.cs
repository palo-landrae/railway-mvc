using System.ComponentModel.DataAnnotations;

namespace RailwayModel.Models
{
  public class AvailableTicket
  {
    [Key]
    public string TicketId { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public string TrainName { get; set; }

    [Required]
    public string Line { get; set; }

    [Required]
    public string DepartureStation { get; set; }

    [Required]
    public string ArrivalStation { get; set; }

    [Required]
    public DateTime DepartureTime { get; set; }

    [Required]
    public DateTime ArrivalTime { get; set; }
  }
}

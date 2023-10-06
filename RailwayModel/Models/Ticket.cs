using System.ComponentModel.DataAnnotations;

namespace RailwayModel.Models
{
  public class Ticket
  {
    [Key]
    public string TicketId { get; set; }

    [Required]
    public int TrainScheduleId { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public bool IsValidated { get; set; } = false;

    [Required]
    public DateTime CreatedAt { get; set; }

    public TrainSchedule TrainSchedule { get; set; }
  }
}

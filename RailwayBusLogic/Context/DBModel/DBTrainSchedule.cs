using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
  public class DBTrainSchedule
  {
    [Key]
    public int ScheduleId { get; set; }

    [Required]
    public int TrainId { get; set; }

    [Required]
    public short DepartureStationId { get; set; }

    [Required]
    public short ArrivalStationId { get; set; }

    [Required]
    public DateTime DepartureTime { get; set; }

    [Required]
    public DateTime ArrivalTime { get; set; }

    public DBTrain Train { get; set; }
    public DBStation DepartureStation { get; set; }
    public DBStation ArrivalStation { get; set; }
  }
}

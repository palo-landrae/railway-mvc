using System.ComponentModel.DataAnnotations;

namespace RailwayModel.Models
{
    public class TrainSchedule
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

        public Train Train { get; set; }
        public Station DepartureStation { get; set; }
        public Station ArrivalStation { get; set; }
    }
}

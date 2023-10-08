using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
    public class DBTicket
    {
        [Key]
        public string ticketId { get; set; }

        [Required]
        public int trainScheduleId { get; set; }

        [Required]
        public decimal price { get; set; }

        [Required]
        public bool isValidated { get; set; } = false;

        public DateTime createdAt { get; set; }

        public DBTrainSchedule trainSchedule { get; set; }
    }
}

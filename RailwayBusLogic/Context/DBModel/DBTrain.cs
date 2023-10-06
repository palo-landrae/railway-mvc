using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
    public class DBTrain
    {
        [Key]
        public int TrainId { get; set; }

        [Required]
        public string TrainName { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public short Capacity { get; set; }
    }
}

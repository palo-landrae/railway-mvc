using System.ComponentModel.DataAnnotations;

namespace RailwayModel.Models
{
    public class Train
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

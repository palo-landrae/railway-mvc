using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
    public class DBStation
    {
        [Key]
        public short StationId { get; set; }

        [Required]
        public string StationName { get; set; }

        public string Zone { get; set; }

        public string Line { get; set; }

        public float? Longitude { get; set; }

        public float? Latitude { get; set; }
    }
}

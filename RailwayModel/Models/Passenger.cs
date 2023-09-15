using System.ComponentModel.DataAnnotations;

namespace RailwayModel.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RailwayBusLogic.Context.DBModel
{
    public class DBPassenger
    {
        [Key]
        public int PassengerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}

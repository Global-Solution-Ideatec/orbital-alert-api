using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrbitalAlert.API.Models
{
    public class Alert
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public string Description { get; set; }

        public string Severity { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public City City { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace OrbitalAlert.API.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string RiskLevel { get; set; }

        public List<Alert>? Alerts { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace BoekingssysteemAPI.Model
{
    [Table("Plane")]
    public class Plane
    {
        public int id { get; set; }
        public string name { get; set; }
        public int seats { get; set; }
        public string? airline { get; set; }
        public int? defaultAmountSeats { get; set; }
    }
}

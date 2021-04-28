using System.ComponentModel.DataAnnotations;

namespace CarFinder.Data
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public bool IsNew { get; set; }
        public long Mileage { get; set; }
        public string Color { get; set; }
    }
}

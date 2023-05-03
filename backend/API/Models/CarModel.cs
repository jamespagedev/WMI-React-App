using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        public string PublicId { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public int? CountryId { get; set; }
        public CountryModel? Country { get; set; }
        public string? WMI { get; set; }
        public string? VehicleType { get; set; }
        public DateTime? DateAvailableToPublic { get; set; } = null;
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
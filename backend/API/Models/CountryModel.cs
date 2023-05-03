using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class CountryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<CarModel> Cars { get; set; } = new List<CarModel>();
    }
}
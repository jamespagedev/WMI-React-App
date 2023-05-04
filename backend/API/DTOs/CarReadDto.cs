namespace API.DTOs
{
    public class CarReadDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? WMI { get; set; }
        public string? VehicleType { get; set; }
        public DateTime? DateAvailableToPublic { get; set; } = null;
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
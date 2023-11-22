namespace Car_rental.Model.Entities
{
    public class Booking : BaseAuditEntity
    {
        public int CarAvailabilityId { get; set; }
        public CarAvailability CarAvailability { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public DateTime NextAvailableOn { get; set; }
    }
}

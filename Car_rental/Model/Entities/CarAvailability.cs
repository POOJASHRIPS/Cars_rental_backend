namespace Car_rental.Model.Entities
{
    public class CarAvailability : BaseAuditEntity
    {
        // Foreign key property for Patient
        public int OwnerId { get; set; }

        // Navigation property for the foreign key relationship with Patient
        public Owner Owner { get; set; }

        public int CarId { get; set; }
        public Cars Car { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int CarRegisterNumber { get; set; }
    }
}

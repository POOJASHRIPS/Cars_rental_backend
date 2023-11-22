namespace Car_rental.Model.Entities
{
    public class CarAvailabilityRegister
    {
        public int OwnerId { get; set; }

        public int CarId { get; set; }
      
        public bool IsAvailable { get; set; } = true;
        public int CarRegisterNumber { get; set; }
    }
}

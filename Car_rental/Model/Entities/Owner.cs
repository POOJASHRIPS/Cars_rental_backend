namespace Car_rental.Model.Entities
{
   
        public class Owner : BaseAuditEntity
        {
        public string Name { get; set; }
        public long ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        


    }
}


using System.ComponentModel.DataAnnotations;

namespace Car_rental.Model.Entities
{
    public class OwnerRegistration
    {
        public string Name { get; set; }

        public long ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\S+@\S+$", ErrorMessage = "Input value is an invalid email address!")]
        public string Email { get; set; }

        public string Address { get; set; }
        public string Password { get; set; }
    }
}

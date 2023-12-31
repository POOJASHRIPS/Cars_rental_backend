﻿using System.ComponentModel.DataAnnotations;

namespace Car_rental.Model.Entities
{
    public class UserRegistration
    {
        public string Name { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public long ContactNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\S+@\S+$", ErrorMessage = "Input value is an invalid email address!")]
        public string Email { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string Password { get; set; }
    }
}

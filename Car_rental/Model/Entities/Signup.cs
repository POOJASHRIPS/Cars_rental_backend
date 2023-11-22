using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_rental.Model.Entities
{
    public class Users : BaseAuditEntity
    {
        public string Name { get; set; }
        public long ContactNumber { get; set; }
        public string Email { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string Password { get; set; }

    }
}

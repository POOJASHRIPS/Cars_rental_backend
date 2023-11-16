using Car_rental.Data;
using Car_rental.Model.Entities;

namespace Car_rental.Interface.CarServices
{
    public class Servicescar : ICar
    {
        private readonly Datacontext _context;

        public Servicescar(Datacontext context)
        {
            _context = context;
        }

        public async Task<bool> Register(UserRegistration signup)
        {
                var name = signup.Name;
                if (_context.Signups.Any(u => u.Email == signup.Email)) // Here We are checking whether the user already exists or not. If exists then we dont want to register again.
                {
                    return false;
                }
                var password = BCrypt.Net.BCrypt.HashPassword(signup.Password);


            var Signup = new Users
            {
                Email = signup.Email,
                Name = name,
                Password = password,
                DrivingLicenseNumber = signup.DrivingLicenseNumber,
                ContactNumber = signup.ContactNumber

            };



            _context.Signups.Add(Signup);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}

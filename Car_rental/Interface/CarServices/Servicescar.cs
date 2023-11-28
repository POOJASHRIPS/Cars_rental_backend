using Car_rental.Data;
using Car_rental.Model.Entities;
using Microsoft.EntityFrameworkCore;

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



        public async Task<bool> CarAvailability(CarAvailabilityRegister carAvailabilityRegister)
        {



            var Availability = new CarAvailability
            {
                OwnerId = carAvailabilityRegister.OwnerId,
                CarId = carAvailabilityRegister.CarId,
                IsAvailable = carAvailabilityRegister.IsAvailable,
                CarRegisterNumber = carAvailabilityRegister.CarRegisterNumber
                

            };

            _context.carsAvailability.Add(Availability);
            await _context.SaveChangesAsync();
            return true;

        }




        public async Task<bool> OwnerRegister(OwnerRegistration owner)
        {
            var name = owner.Name;

            if (_context.owners.Any(u => u.Email == owner.Email)) // Here We are checking whether the user already exists or not. If exists then we dont want to register again.
            {
                return false;
            }
            var password = BCrypt.Net.BCrypt.HashPassword(owner.Password);


            var owners = new Owner
            {
                Email = owner.Email,
                Name = name,
                Password = password,
                ContactNumber = owner.ContactNumber

            };



            _context.owners.Add(owners);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Login(Login login)
        {
            var User = await _context.Signups.FirstOrDefaultAsync(p => p.Email == login.email);

            if (User == null)
            {
                return false;

            }
            if (!BCrypt.Net.BCrypt.Verify(login.password, User.Password))
            {
                return false;  // Invalid password.
            }

            return true;  // Login successful.

        }

        public async Task<bool> Ownerlogin(Login ownerlogin)
        {
            var owner = await _context.owners.FirstOrDefaultAsync(p => p.Email == ownerlogin.email);

            if (owner == null)
            {
                return false;

            }
            if (!BCrypt.Net.BCrypt.Verify(ownerlogin.password, owner.Password))
            {
                return false;  // Invalid password.
            }

            return true;  // Login successful.

        }

        public async Task<bool> Cars(CarRegistration carRegistration)
        {

            var car = new Cars
            {

                Name = carRegistration.Name,
                type = carRegistration.type


            };



            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return true;

        }


        public async Task<List<Cars>> GetAllCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return cars;
        }

       
        //start
        public async Task<bool> CheckCarAvailability(int carId)
        {
            var carAvailability = await _context.carsAvailability
                .FirstOrDefaultAsync(c => c.CarId == carId && c.IsAvailable);
            return carAvailability != null;
        }

            public async Task<bool> BookCar(int carId, int userId)
            {
                var carAvailability = await _context.carsAvailability
                    .FirstOrDefaultAsync(c => c.CarId == carId && c.IsAvailable);

                if (carAvailability != null)
                {
                    carAvailability.IsAvailable = false;

                    var booking = new Booking
                    {
                        CarAvailabilityId = carAvailability.Id,
                        UserId = userId,
                        NextAvailableOn = DateTime.UtcNow.AddHours(1) // Assuming the next available time is 1 hour from now.
                    };

                    _context.bookings.Add(booking);
                    await _context.SaveChangesAsync();
                    return true;
                }

                return false;
            }

        public async Task<bool> CancelBooking(int bookingId)
        {
            var booking = await _context.bookings.FindAsync(bookingId);

            if (booking != null && booking.NextAvailableOn > DateTime.UtcNow)
            {
                var carAvailability = await _context.carsAvailability
                    .FirstOrDefaultAsync(c => c.Id == booking.CarAvailabilityId);

                if (carAvailability != null)
                {
                    carAvailability.IsAvailable = true;
                    _context.bookings.Remove(booking);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }

            return false;
        }


        //end
    }
}

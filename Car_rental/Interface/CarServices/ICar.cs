using Car_rental.Model.Entities;

namespace Car_rental.Interface.CarServices
{
    public interface ICar
    {
        Task<bool> Register(UserRegistration signup);
        Task<bool> Login(Login login);
        Task<bool> Ownerlogin(Login ownerlogin);
        Task<bool> OwnerRegister(OwnerRegistration ownerRegistration);
        Task<bool> Cars(CarRegistration carRegistration);
        Task<bool> CarAvailability(CarAvailabilityRegister carAvailabilityRegister);

        Task GetAllCars();
        Task<bool> CheckCarAvailability(int carId);
        Task<bool> BookCar(int carId, int userId);
        Task<bool> CancelBooking(int bookingId);
       // Task<bool> CarAvailabilityRegister(CarAvailabilityRegister availability);
        
    }
}

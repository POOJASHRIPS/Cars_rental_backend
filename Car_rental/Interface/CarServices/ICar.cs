using Car_rental.Model.Entities;

namespace Car_rental.Interface.CarServices
{
    public interface ICar
    {
        Task<bool> Register(UserRegistration signup);
     
    }
}

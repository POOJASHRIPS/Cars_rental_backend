using Car_rental.Interface.CarServices;
using Car_rental.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Car_rental.Controllers
{
    public class CarController : ControllerBase
    {
        private readonly ICar _carservices;

        public CarController(ICar carservices)
        {
            _carservices = carservices;
        }



        [HttpGet("GetAllCars")]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _carservices.GetAllCars();
            return Ok(cars);
        }





        [HttpPost("CarRegister")]
        public async Task<IActionResult> Cars(CarRegistration carRegistration)
        {
            return Ok(await _carservices.Cars(carRegistration));

        }


        [HttpPost("CarAvailabilityRegisters")]
        public async Task<IActionResult> CarAvailability([FromBody] CarAvailabilityRegister carAvailabilityRegister)
        {
            return Ok(await _carservices.CarAvailability(carAvailabilityRegister));
        }


        [HttpPost("CheckAvailability")]
        public async Task<IActionResult> CheckAvailability(int carId)
        {
            var isAvailable = await _carservices.CheckCarAvailability(carId);
            return Ok(new { IsAvailable = isAvailable });
        }

        [HttpPost("BookCar")]
        public async Task<IActionResult> BookCar(int carId, int userId)
        {
            var result = await _carservices.BookCar(carId, userId);
            return Ok(new { Success = result });
        }

        [HttpPost("CancelBooking")]
        public async Task<IActionResult> CancelBooking(int bookingId)
        {
            var result = await _carservices.CancelBooking(bookingId);
            return Ok(new { Success = result });
        }

        
    }
}

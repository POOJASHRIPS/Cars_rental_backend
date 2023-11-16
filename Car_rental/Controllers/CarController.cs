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

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegistration signup)
        {
            return Ok(await _carservices.Register(signup));

        }
       
        

    }
}

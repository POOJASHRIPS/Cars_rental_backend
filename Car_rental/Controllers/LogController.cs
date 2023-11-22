using Car_rental.Interface.CarServices;
using Car_rental.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Car_rental.Controllers
{
    public class LogController : ControllerBase
    {
        private readonly ICar _carservices;

        public LogController(ICar carservices)
        {
            _carservices = carservices;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegistration signup)
        {
            return Ok(await _carservices.Register(signup));

        }


        [HttpPost("OwnerRegister")]
        public async Task<IActionResult> OwnerRegister(OwnerRegistration owner)
        {
            return Ok(await _carservices.OwnerRegister(owner));

        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(Login login)
        {

            return Ok(await _carservices.Login(login));


        }

        [HttpPost("Ownerlogin")]
        public async Task<IActionResult> Ownerlogin(Login ownerlogin)
        {

            return Ok(await _carservices.Ownerlogin(ownerlogin));


        }
    }
}

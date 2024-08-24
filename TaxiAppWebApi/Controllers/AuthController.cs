using Microsoft.AspNetCore.Mvc;
using TaxiAppWebApi.Models;
using TaxiAppWebApi.Data;
using Microsoft.AspNetCore.Identity;

namespace TaxiAppWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            

            var user = new User
            {
             
                UserName = model.UserName,
                Email = model.Email,
                PasswordHash = "",
                Name = model.Name,
                Lastname = model.Lastname,
                DateOfBirth = model.DateOfBirth,
                Address = model.Address,
                Type = model.Type,
                Picture = model.Picture
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok(new { Message = "Registration successful" });
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return BadRequest(ModelState);
        }
    }
}

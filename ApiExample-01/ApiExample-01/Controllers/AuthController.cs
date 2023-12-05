using ApiExample_01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExample_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        public static List<User> users = new List<User>();
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            string passwordHash
                = BCrypt.Net.BCrypt.HashPassword(request.Password);
            user.Username = request.Username;
            user.PasswordHash = passwordHash;
           
            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult <User>Login(UserDto request )
        {
            if (user.Username!=request.Username)
            {
                return BadRequest("User Not Found!");
            }
            if ()
            {

            }


            return Ok();
        }


    }
}

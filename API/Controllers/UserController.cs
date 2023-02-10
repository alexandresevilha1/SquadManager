using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Autentica usuário
        /// </summary>
        /// <param name="user">Username e senha do usuário</param>
        /// <returns>Ok</returns>
        /// 
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (user.Password == "123")
                return Ok(new { response = "Ok" });
            else
                return Ok(new { response = "ERROR" });
        }
    }
}

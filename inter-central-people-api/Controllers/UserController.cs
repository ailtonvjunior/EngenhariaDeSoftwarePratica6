using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUsuarioService _service;

        public UserController(IUsuarioService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUser([FromQuery] string Bi)
        {
            var user = await _service.GetUserDBO(Bi);
            if (user == null)   
                return NotFound();
            return Ok(user);
        }
    }
}

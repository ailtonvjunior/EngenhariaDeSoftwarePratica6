using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace inter_people_central_api.Controllers
{
  [Route("api/[controller]")]
  public class HealthController : Controller
  {
    [AllowAnonymous]
    [HttpGet]
    public object GetStatus()
    {
      return new OkObjectResult( "Health Status: OK!");
    }
  }
}

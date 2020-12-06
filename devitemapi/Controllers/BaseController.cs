using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Controllers
{
    [Authorize]
    // [AllowAnonymous]
    //[Route("api/[controller]/[action]")]
    [Route("api")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BaseController : ControllerBase
    {
    }
}
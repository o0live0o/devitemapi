using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    //[Route("api/[controller]/[action]")]
    [Route("api")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BaseController : ControllerBase
    {
    }
}

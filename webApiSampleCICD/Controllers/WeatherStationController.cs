using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiSampleCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStationController : ControllerBase
    {
        [HttpGet]
        [Route("status")]
        public IActionResult Get()
        {
            return Ok("we are here in WeatherStationController");
        }
    }
}

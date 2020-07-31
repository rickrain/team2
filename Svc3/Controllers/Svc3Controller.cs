using System;
using Microsoft.AspNetCore.Mvc;

namespace Svc3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Hello from 'Svc3'";
        }
    }
}
